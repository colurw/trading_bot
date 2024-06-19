import requests
import schedule
import time
import bitmex
import os
import sys
# import pyttsx3 
from dotenv import load_dotenv 
from time import localtime, gmtime, strftime
exec( open('indicator_private.py').read() )   # avoids circular import


class TestConnection():
    def __init__(self):
        self.timestamp = 'none'
        self.last_timestamp = 'none'
        self.glitch_count = 0

    def test(self, timestamp):
        """ checks websocket stream is updating and records error if not """
        if self.timestamp == self.last_timestamp:
            self.glitch_count += 1
            
            if self.glitch_count > 3:
                message('stream interrupted')
        else:
            self.glitch_count = 0  
        
        self.last_timestamp = timestamp


def get_streamed_data():
    """ get current price from (testnet) websocket stream to avoid API rate limits """
    try:
        response = requests.get('http://localhost:4444/instrument?symbol=XBTUSD')
        data = response.json()[0]
        last_price = data['lastPrice'] 
        timestamp = data['timestamp']

        return last_price, timestamp

    except:
        message('streamer failed')
        sys.exit('streamer failed') 
    

def calculate_order_size(margin, max_risk, price, stop_level):
    """ adjust position sizes according to risk tolerance and stop distance """
    risk_tolerance = max_risk / 100
    stop_fraction = abs(price - stop_level) / price
    capital = margin * price / 100000000   
    order_size = capital * risk_tolerance / stop_fraction
    rounded = round(order_size / 100) * 100 
    leverage = max(rounded, 100) / capital

    message(f'risk level - stop_frac:{stop_fraction} usd:{capital} mar:{margin/100000000} lev:{leverage}')

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


def message(string, speech=False, telegram=True):
    """ logs and vocalises messages  """
    time = strftime("%Y-%m-%d %H:%M:%S", gmtime()) 

    with open('persisted/log.txt', 'a') as file:
        file.write(f'{time} {string} \n') 
    
    # if speech == True:   # Windows only
    #     engine = pyttsx3.init()
    #     voices = engine.getProperty('voices')
    #     engine.setProperty('voice', voices[0].id) 
    #     engine.say(string)
    #     engine.runAndWait()

    if telegram == True:
        token = os.getenv('TELEGRAM_TOKEN')
        chat_id = os.getenv('CHAT_ID')
        requests.get(f'https://api.telegram.org/bot{token}/sendMessage?chat_id={chat_id}&text={string}').json()
    

def get_trade_status(client):
    """ polls market for positions held """
    contracts_held = client.Position.Position_get(filter='{"symbol": "XBTUSD"}').result()[0][0]['currentQty']
    status = 'none'

    if contracts_held > 0:
        status = 'in_long'

    elif contracts_held < 0:
        status = 'in_short'

    return status


MAX_RISK = 5               # % of capital per position, 'False' = $100
FRESH_START = True 
DELAY = 2                  # >1
STOP_TYPE = 'MarkPrice'    # or 'LastPrice'

load_dotenv()  

message('start up')

# create instance of trading indicator
levels = Indicator()   # type: ignore

# create instance of swagger client
client = bitmex.bitmex(test=True, 
                       api_key=os.getenv('TESTNET_KEY'), 
                       api_secret=os.getenv('TESTNET_SECRET'))   

# create instance of websocket stream tester
is_connected = TestConnection()

trade_status = get_trade_status(client)  

if FRESH_START:
    trade_status == 'none'
    clear_book(client)
    message('fresh start')
    
if trade_status != 'none':

    with open('persisted/trailing_stop.txt', 'r') as file: 
        trailing_stop = file.read()    

    with open('persisted/liquidation_price.txt', 'r') as file: 
        liquidation_price = file.read()   

levels.calculate(buckets= '5m', data_length=15, graph=False)   # type: ignore

schedule.every(5).minutes.do(levels.calculate, buckets= '5m', data_length=15, graph=False)   # type: ignore 
# schedule.every().hour.at('00:03').do(levels.calculate, buckets= '1h', data_length=20, graph=False)   # type: ignore 
# schedule.every().day.at("00:00:03", "UTC").do(levels.calculate, buckets= '1h', data_length=20*4, resampled_buckets='4h')   
# schedule.every().day.at("04:00:03", "UTC").do(levels.calculate, buckets= '1h', data_length=20*4, resampled_buckets='4h')
# schedule.every().day.at("08:00:03", "UTC").do(levels.calculate, buckets= '1h', data_length=20*4, resampled_buckets='4h')
# schedule.every().day.at("12:00:03", "UTC").do(levels.calculate, buckets= '1h', data_length=20*4, resampled_buckets='4h')
# schedule.every().day.at("16:00:03", "UTC").do(levels.calculate, buckets= '1h', data_length=20*4, resampled_buckets='4h')
# schedule.every().day.at("20:00:03", "UTC").do(levels.calculate, buckets= '1h', data_length=20*4, resampled_buckets='4h')
# (check EC2 time sync method)

while True:

    schedule.run_pending()   # recalculate trigger levels every every new candle 
    time.sleep(DELAY)

    trade_status = get_trade_status(client)  

    last_price, timestamp = get_streamed_data()   # get current price every {DELAY} sceonds
    
    is_connected.test(timestamp)


    if last_price > levels.long_trigger and trade_status == 'none':

        # open long position
        clear_book(client)
        margin = client.User.User_getMargin(currency='XBt').result()[0]['amount']    # must set account to cross margin
        size = calculate_order_size(margin, MAX_RISK, last_price, levels.lower_bound)
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Market', 
                               side='Buy', 
                               orderQty=size).result()
        trade_status = 'in_long'
        message(f'long trade opened {last_price} {size}')

        # set long stop
        time.sleep(3)
        liquidation_price = client.Position.Position_get(filter='{"symbol": "XBTUSD"}').result()[0][0]['liquidationPrice']
        trailing_stop = max(levels.lower_bound, float(liquidation_price) * 1.1) 
        print('LB = ', int(levels.lower_bound))
        print('LIQP = ', int(liquidation_price))  
        print('STOPPX = ', int(trailing_stop))
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Stop', 
                               orderQty=-size, 
                               stopPx=int(trailing_stop), 
                               execInst=STOP_TYPE,    
                               clOrdID='long_stop').result()
        message(f'long stop set {int(trailing_stop)}')
        

    if last_price < levels.short_trigger and trade_status == 'none':

        # open short position
        clear_book(client)
        margin = client.User.User_getMargin(currency='XBt').result()[0]['amount']   
        size = calculate_order_size(margin, MAX_RISK, last_price, levels.upper_bound)
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Market', 
                               side='Sell', 
                               orderQty=-size).result()  
        trade_status = 'in_short'
        message(f'short trade opened {last_price} {size}')

        # set short stop
        time.sleep(3)
        liquidation_price = client.Position.Position_get(filter='{"symbol": "XBTUSD"}').result()[0][0]['liquidationPrice']
        trailing_stop = min(levels.upper_bound, float(liquidation_price) / 1.1) 
        print('UB = ', int(levels.upper_bound))
        print('LIQP = ', int(liquidation_price))  
        print('STOPPX = ', int(trailing_stop))
        client.Order.Order_new(symbol='XBTUSD', 
                               ordType='Stop', 
                               orderQty=size, 
                               stopPx=int(trailing_stop), 
                               execInst=STOP_TYPE,    
                               clOrdID='short_stop').result() 
        message(f'short stop set {int(trailing_stop)}')


    if trade_status == 'in_long':

        if max(levels.lower_bound, float(liquidation_price) * 1.1) > float(trailing_stop):

            # raise long trailing stop level
            trailing_stop = max(levels.lower_bound, float(liquidation_price) * 1.1)
            client.Order.Order_amend(origClOrdID='long_stop', stopPx=int(trailing_stop)).result()
            message(f'long stop raised {int(trailing_stop)}')

        if levels.lower_bound < float(liquidation_price) * 1.1:
            message('reduce max risk')


    if trade_status == 'in_short':

        if min(levels.upper_bound, float(liquidation_price) / 1.1) < float(trailing_stop):

            # reduce short trailing stop level
            trailing_stop = min(levels.upper_bound, float(liquidation_price) / 1.1)
            client.Order.Order_amend(origClOrdID='short_stop', stopPx=int(trailing_stop)).result() 
            message(f'short stop lowered {int(trailing_stop)}')

        if levels.upper_bound > liquidation_price / 1.1:
            message('reduce max risk')


    if trade_status != 'none':

        with open('persisted/trailing_stop.txt', 'w') as file:    # container needs volume mount
            # write to volume in case container restarts
            file.write(str(trailing_stop))    

        with open('persisted/liquidation_price.txt', 'w') as file:
            # write to volume in case container restarts
            file.write(str(liquidation_price))  

