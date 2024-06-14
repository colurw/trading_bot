import requests
import schedule
import time
import bitmex
import os
import sys
import pyttsx3
from dotenv import load_dotenv
exec( open('trading_algorithm/calculate_levels_private.py').read() )   # allows global vars (necessary with schedule()) to be updated
from time import localtime, gmtime, strftime


def get_streamed_data():
    """ get current price from (testnet) websocket stream to avoid API rate limits """
    try:
        response = requests.get('http://localhost:4444/instrument?symbol=XBTUSD')
        data = response.json()[0]
        last_price = data['lastPrice'] 
        lowest_ask = data['askPrice']
        highest_bid = data['bidPrice']
        timestamp = data['timestamp']

        return last_price, lowest_ask, highest_bid, timestamp

    except:
        log_message('streamer failed')
        raise Exception('streamer failed')
        # sys.exit('streamer failed') 
    

def check_connection(timestamp):
    """ terminates program if two similar timestamps are received from bitmex_streamer (containers will auto-restart) """

    with open('trading_algorithm/persisted/timestamp.txt', 'r') as file:    
        last_timestamp = file.read()

    with open('trading_algorithm/persisted/timestamp.txt', 'w') as file:
        file.write(timestamp)
    
    if timestamp == last_timestamp:
        log_message(f'stream repeated')
        raise Exception('stream repeated')
        # sys.exit('stream repeated')     
        

def calculate_order_size(margin, max_risk, price, stop_level):
    """ adjust position sizes according to risk tolerance and stop distance """

    risk_tolerance = max_risk / 100
    stop_fraction = abs(price - stop_level) / price
    capital = margin * price / 100000000
    order_size = capital * risk_tolerance / stop_fraction
    rounded = round(order_size / 100) * 100
    
    return max(rounded, 100)    


def clear_book(client):
    """ clears open positions and stops """
    try:
        client.Order.Order_new(symbol='XBTUSD', execInst='Close').result()
    except:
        print('no open positions') 

    try:
        client.Order.Order_cancelAll(symbol='XBTUSD').result() 
    except:
        print('no open stops')


def log_message(string, text2speech=True, print=True):

    time = strftime("%Y-%m-%d %H:%M:%S", localtime())  # also gmtime()

    with open('trading_algorithm/persisted/log.txt', 'a') as file:
        file.write(f'{time} {string} \n') 
    
    if text2speech == True:
        engine = pyttsx3.init()
        voices = engine.getProperty('voices')
        engine.setProperty('voice', voices[0].id) 
        engine.say(string)
        engine.runAndWait()
    

def get_trade_status(client):
    quantity = client.Position.Position_get(filter='{"symbol": "XBTUSD"}').result()[0][0]['currentQty']
    status = 'none'
    
    if quantity > 0:
        status = 'in_long'

    elif quantity < 0:
        status = 'in_short'

    return status


MAX_RISK = 3
FRESH_START = True   
DELAY = 3

load_dotenv()   # get env vars from .env file
log_message('start up')

client = bitmex.bitmex(test=True, 
                       api_key=os.getenv('TESTNET_KEY'), 
                       api_secret=os.getenv('TESTNET_SECRET'))   

trade_status = get_trade_status(client)    

if FRESH_START:
    trade_status == 'none'
    clear_book(client)
    log_message('fresh start')
    
if trade_status != 'none':

    with open('trading_algorithm/persisted/trailing_stop.txt', 'r') as file: 
        trailing_stop = file.read()    

    with open('trading_algorithm/persisted/liquidation_price.txt', 'r') as file: 
        liquidation_price = file.read()   

long_trigger = 0.0    # global variables - updated by calculate_levels()
short_trigger = 0.0
upper_bound = 0.0
lower_bound = 0.0

calculate_levels(graph=True) # type: ignore

schedule.every(5).minutes.at(':00').do(calculate_levels, graph=True)   # type: ignore   # every 5 minutes!!

while True:
    schedule.run_pending()   # recalculate levels every every new candle - check EC2 time sync method
    time.sleep(DELAY)

    trade_status = get_trade_status(client)  

    # get current prices every second
    last_price, lowest_ask, highest_bid, timestamp = get_streamed_data()   # highest/lowest necessary?
    print('UB = ', int(upper_bound))
    print('LB = ', int(lower_bound))
    print('LT = ', int(long_trigger)) 
    print('LP = ', int(last_price)) 
    print('ST = ', int(short_trigger))
    print()
    # os.system('cls')   
    check_connection(timestamp)

    if last_price > long_trigger and trade_status == 'none':

        # open long position
        clear_book(client)
        margin = client.User.User_getMargin(currency='XBt').result()[0]['amount']    # must set account to cross margin
        size = calculate_order_size(margin, MAX_RISK, last_price, lower_bound)
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Market', 
                               side='Buy', 
                               orderQty=size).result()
        trade_status = 'in_long'
        log_message(f'{last_price} {size} long trade opened')

        # set long stop
        time.sleep(3)
        liquidation_price = client.Position.Position_get(filter='{"symbol": "XBTUSD"}').result()[0][0]['liquidationPrice']
        trailing_stop = max(lower_bound, float(liquidation_price) * 1.1) 
        print('LB = ', int(lower_bound))
        print('LIQP = ', int(liquidation_price))  
        print('STOPPX = ', int(trailing_stop))
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Stop', 
                               orderQty=-size, 
                               stopPx=int(trailing_stop), 
                               execInst='MarkPrice', 
                               clOrdID='long_stop').result()
        log_message(f'{int(trailing_stop)} long stop set')
        
    if last_price < short_trigger and trade_status == 'none':

        # open short position
        clear_book(client)
        margin = client.User.User_getMargin(currency='XBt').result()[0]['amount']   
        size = calculate_order_size(margin, MAX_RISK, last_price, upper_bound)
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Market', 
                               side='Sell', 
                               orderQty=-size).result()  
        trade_status = 'in_short'
        log_message(f'{last_price} {size} short trade opened')

        # set short stop
        time.sleep(3)
        liquidation_price = client.Position.Position_get(filter='{"symbol": "XBTUSD"}').result()[0][0]['liquidationPrice']
        trailing_stop = min(upper_bound, float(liquidation_price) / 1.1) 
        print('UB = ', int(upper_bound))
        print('LIQP = ', int(liquidation_price))  
        print('STOPPX = ', int(trailing_stop))
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Stop', 
                               orderQty=size, 
                               stopPx=int(trailing_stop), 
                               execInst='MarkPrice', 
                               clOrdID='short_stop').result() 
        log_message(f'{int(trailing_stop)} short stop set')


    if trade_status == 'in_long':

        if max(lower_bound, float(liquidation_price) * 1.1) > float(trailing_stop):
            # raise long trailing stop level
            trailing_stop = max(lower_bound, float(liquidation_price) * 1.1)
            client.Order.Order_amend(origClOrdID='long_stop', stopPx=int(trailing_stop)).result()
            log_message(f'{int(trailing_stop)} long stop raised')

        if lower_bound < float(liquidation_price) * 1.1:
            log_message('reduce max risk')

    if trade_status == 'in_short':
        
        if min(upper_bound, float(liquidation_price) / 1.1) < float(trailing_stop):
            # reduce short trailing stop level
            trailing_stop = min(upper_bound, float(liquidation_price) / 1.1)
            client.Order.Order_amend(origClOrdID='short_stop', stopPx=int(trailing_stop)).result() 
            log_message(f'{int(trailing_stop)} short stop lowered')

        if upper_bound > liquidation_price / 1.1:
            log_message('reduce max risk')

    if trade_status != 'none':

        with open('trading_algorithm/persisted/trailing_stop.txt', 'w') as file:    # container needs volume mount
            # write to volume in case container restarts
            file.write(str(trailing_stop))    

        with open('trading_algorithm/persisted/liquidation_price.txt', 'w') as file:
            # write to volume in case container restarts
            file.write(str(liquidation_price))  

