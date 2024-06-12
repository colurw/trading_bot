import requests
import schedule
import time
import bitmex
import os
import sys
from calculate_levels_private import calculate_levels
from dotenv import load_dotenv


def get_latest_data():
    """ get current price from (testnet!) websocket stream to avoid API rate limits """
    try:
        response = requests.get('http://localhost:4444/instrument?symbol=XBTUSD')
        data = response.json()[0]
        current_mid = data['midPrice']   
        lowest_ask = data['askPrice']
        highest_bid = data['bidPrice']
        timestamp = data['timestamp']

        return current_mid, lowest_ask, highest_bid, timestamp

    except:
        raise Exception('lost connection!')
        # time.sleep(10)
        # sys.exit(1) 
    

def check_connection(timestamp):
    """ terminates program if two similar timestamps are received from bitmex_streamer (containers will auto-restart) """

    with open('persisted_data/timestamp.txt', 'r') as file:    # persisted_data needs volume mount in container
        last_timestamp = file.read()

    with open('persisted_data/timestamp.txt', 'w') as file:
        file.write(timestamp)

    if timestamp == last_timestamp:
        time.sleep(10)
        sys.exit(2)     
        

def calculate_order_size(total_assets, max_risk, current_price, stop_level):
    """ adjust position sizes according to risk tolerance and stop distance """

    portion_lost = total_assets * (max_risk / 100) * current_price
    potential_change = abs(current_price - stop_level) / current_price
    order_size = portion_lost / potential_change
    
    return order_size


def exit_position(client):
    """ handles error if no current position found """
    try:
        client.Order.Order_new(symbol='XBTUSD', execInst='Close').result()

    except:
        print('no open positions')


# ATR_LENGTH = 14
# ATR_MULT = 2
# DATA_LENGTH = 40
# CANDLES = '1h'
MAX_RISK = 3

load_dotenv()   # get env vars from .env file

client = bitmex.bitmex(test=True, 
                       api_key=os.getenv('TESTNET_KEY'), 
                       api_secret=os.getenv('TESTNET_SECRET'))   

with open('trading_algorithm/persisted_data/trade_direction.txt', 'r') as file:   # persisted_data needs volume mount in container
    trade_status = file.read()

long_trigger = 0.0    # global variables - updated by calculate_levels()
short_trigger = 0.0
upper_bound = 0.0
lower_bound = 0.0

# schedule.every().minute.at(':00').do(calculate_levels, DATA_LENGTH, CANDLES, ATR_LENGTH, ATR_MULT, graph=False)
schedule.every().minute.at(':00').do(calculate_levels, graph=False)   # every minute!!

while True:
    schedule.run_pending()   # get historic data and calculate significant levels on turn of each hour

    time.sleep(1)
    close_mid, lowest_ask, highest_bid, timestamp = get_latest_data()   # get current prices every second
    check_connection(timestamp)

    if highest_bid > long_trigger and trade_status == 'none':
        # close open positions, buy long, set long stop
        exit_position(client)
        trailing_stop = lower_bound
        total_assets = client.User.User_getMargin(currency='XBt').result()[0]['amount']   
        size = calculate_order_size(total_assets, MAX_RISK, close_mid, trailing_stop)
        client.Order.Order_new(symbol='XBTUSD', ordType='Market', side='Buy', orderQty=100).result()   
        client.Order.Order_new(symbol='XBTUSD', ordType='Stop', orderQty=-100, stopPx=68100, execInst='LastPrice', clOrdID='long_stop').result()
        trade_status = 'in_long'

    if lowest_ask < short_trigger and trade_status == 'none':
        # close open positions, buy short, set short stop
        exit_position(client)
        trailing_stop = upper_bound
        total_assets = client.User.User_getMargin(currency='XBt').result()[0]['amount']   
        size = calculate_order_size(total_assets, MAX_RISK, close_mid, trailing_stop)
        client.Order.Order_new(symbol='XBTUSD', ordType='Market', side='Sell', orderQty=-100).result()   
        client.Order.Order_new(symbol='XBTUSD', ordType='Stop', orderQty=100, stopPx=70100, execInst='LastPrice', clOrdID='short_stop').result() 
        trade_status = 'in_short'

    if trade_status == 'in_long' and lower_bound > trailing_stop:
        # raise long stop level
        trailing_stop = lower_bound
        client.Order.Order_amend(origClOrdID='long_stop', stopPx=68700).result()

    if trade_status == 'in_short' and upper_bound < trailing_stop:
        # lower short stop level
        trailing_stop = upper_bound
        client.Order.Order_amend(origClOrdID='short_stop', stopPx=69600).result() 

    if trade_status == 'in_long' and lowest_ask < trailing_stop:
        # position closed by previously placed long stop order 
        trade_status = 'none'

    if trade_status == 'in_short' and highest_bid > trailing_stop:
        # position closed by previously placed short stop order 
        trade_status = 'none'

    with open('trading_algorithm/persisted_data/trade_direction.txt', 'w') as file:
        # write status to volume in case container restarts
        file.write(trade_status)