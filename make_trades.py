import requests
import schedule
import time
from calculate_levels_private import calculate_levels
import bitmex
import os


def get_latest_data():
    """ get current price from (testnet!) websocket stream to avoid API rate limits """
    try:
        response = requests.get('http://localhost:4444/instrument?symbol=XBTUSD')
        data = response.json()[0]
        current_price = data['midPrice']   # maybe not the best idea?
        current_low = data['low']
        current_high = data['high']

        return current_price, current_high, current_low

    except:
        raise Exception('lost connection!')


def determine_position_size(max_risk, current_price, stop_level):
    """ adjust position sizes according to risk tolerance """
    size = abs((max_risk * current_price) / (100 * stop_level))
    
    return size


ATR_LENGTH = 14
ATR_MULT = 2
DATA_LENGTH = 40
CANDLES = '1h'
MAX_RISK = 3

API_KEY = os.getenv('TESTNET_KEY')
API_SECRET = os.getenv('TESTNET_SECRET')


client = bitmex.bitmex(test=True, api_key=API_KEY, api_secret=API_SECRET)   # testnet only
result = client.Quote.Quote_get(symbol="XBTUSD", reverse=True, count=1).result()
print(result[0][0]['bidPrice'])

long_trigger = 0    # global variables - updated by calculate_levels()
short_trigger = 0
upper_bound = 0
lower_bound = 0

schedule.every().minute.at(":00").do(calculate_levels, DATA_LENGTH, CANDLES, ATR_LENGTH, ATR_MULT, graph=False)

while True:
    schedule.run_pending()   # get historic data and calculate significant levels on turn of each hour

    time.sleep(1)
    close, high, low = get_latest_data()   # get current prices every second

    if high > long_trigger and trade == 'none':
        trade = 'in_long'
        stop = lower_bound
        size = determine_position_size(MAX_RISK, close, stop)

    if low < short_trigger and trade == 'none':
        trade = 'in_short'
        stop = upper_bound
        size = determine_position_size(MAX_RISK, close, stop)

    if trade == 'in_long' and lower_bound > stop:
        stop = lower_bound

    if trade == 'in_short' and upper_bound < stop:
        stop = upper_bound

    if trade == 'in_long' and low < stop:
        trade = 'none'

    if trade == 'in_short' and high > stop:
        trade = 'none'