import requests
import schedule
import time
from calculate_levels_private import calculate_levels
import bitmex
import os
import sys
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
    """ terminates program if two similar timestamps are received from bitmex_streamer (containers will auto-restart)"""

    with open('persisted_data/timestamp.txt', 'r') as file:    # persisted_data needs bind mount in container
        last_timestamp = file.read()

    with open('persisted_data/timestamp.txt', 'w') as file:
        file.write(timestamp)

    if timestamp == last_timestamp:
        time.sleep(10)
        sys.exit(2)     
        

def calculate_order_size(total_assets, max_risk, current_price, stop_level):
    """ adjust position sizes according to risk tolerance and stop distance """

    portion_lost = max_risk / 100
    potential_change = abs(current_price - stop_level)
    order_size = portion_lost * total_assets / potential_change
    
    return order_size


ATR_LENGTH = 14
ATR_MULT = 2
DATA_LENGTH = 40
CANDLES = '1h'
MAX_RISK = 3

load_dotenv()

client = bitmex.bitmex(test=True, 
                       api_key=os.getenv('TESTNET_KEY'), 
                       api_secret=os.getenv('TESTNET_SECRET'))   

# result = client.Quote.Quote_get(symbol="XBTUSD", reverse=True, count=1).result()
# print('ask', result[0][0]['askPrice'])
# print('bid', result[0][0]['bidPrice'])

# result = client.User.User_getMargin(currency="XBt").result()[0]['amount']   
# print('amount', result)    # in satoshis

with open('persisted_data/trade_direction.txt', 'r') as file:    # persisted_data needs bind mount in container
    trade_status = file.read()

long_trigger = 0.0    # global variables - updated by calculate_levels()
short_trigger = 0.0
upper_bound = 0.0
lower_bound = 0.0

# schedule.every().minute.at(":00").do(calculate_levels, DATA_LENGTH, CANDLES, ATR_LENGTH, ATR_MULT, graph=False)

while True:
    # schedule.run_pending()   # get historic data and calculate significant levels on turn of each hour

    time.sleep(1)
    # close_mid, lowest_ask, highest_bid, timestamp = get_latest_data()   # get current prices every second
    # check_connection(timestamp)

    # if highest_bid > long_trigger and trade_status == 'none':
    #     trade_status = 'in_long'
    #     trailing_stop = lower_bound
    #     total_assets = client.User.User_getMargin(currency="XBt").result()[0]['amount']   
    #     size = calculate_order_size(total_assets, MAX_RISK, close_mid, stop)

    # if lowest_ask < short_trigger and trade_status == 'none':
    #     trade_status = 'in_short'
    #     trailing_stop = upper_bound
    #     total_assets = client.User.User_getMargin(currency="XBt").result()[0]['amount']   
    #     size = calculate_order_size(total_assets, MAX_RISK, close_mid, stop)

    # if trade_status == 'in_long' and lower_bound > trailing_stop:
    #     trailing_stop = lower_bound

    # if trade_status == 'in_short' and upper_bound < trailing_stop:
    #     trailing_stop = upper_bound

    # if trade_status == 'in_long' and lowest_ask < trailing_stop:
    #     trade_status = 'none'
    #     close all positions and stops

    # if trade_status == 'in_short' and highest_bid > trailing_stop:
    #     trade_status = 'none'
    #     close all positions and stops

    # with open('persisted_data/trade_direction.txt', 'w') as file:
    #     file.write(trade_status)