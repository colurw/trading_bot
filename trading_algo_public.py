import requests
import pandas as pd
import plotly.graph_objects as pgo
import schedule
import time
import os


def wwma(pd_series, period):
    """ w. wilder's EMA """
    
    return pd_series.ewm(alpha=1/period, adjust=False, ignore_na=True).mean()


def atr(df, length):
    """ average true range (for columns with latest values at bottom) """
    df_high, df_low, df_prev_close = df['high'], df['low'], df['close'].shift()
    df_tr = [df_high- df_low, df_high - df_prev_close, df_low - df_prev_close]
    df_tr = [tr.abs() for tr in df_tr]
    df_tr = pd.concat(df_tr, axis=1).max(axis=1)
    df_atr = wwma(df_tr, length)
    
    return df_atr


def useful_stuff():
    ...

    return ...


def calculate_levels(length, candles, atr_multiplier, graph=True):

    # glob vars as schedule() can't handle returned data
    global long_trigger
    global short_trigger
    global upper_bound
    global lower_bound

    # get 1hr bucketed historic prices from API and load into dataframe
    response = requests.get(f'https://www.bitmex.com/api/v1/trade/bucketed?binSize={candles}&partial=false&symbol=XBTUSD&count={length}&reverse=true')
    recent_data = response.json()
    df = pd.DataFrame.from_dict(recent_data)
    df['hour'] = df.timestamp.str[11:13]
    df = df.drop(columns=['vwap', 'lastSize', 'turnover', 
                          'homeNotional', 'foreignNotional', 
                          'trades', 'symbol'], axis=1)
    
    # reverse dataframe
    df = df.iloc[::-1]

    df['ATR'] = atr(df, length=ATR_LENGTH)
    df['zz'] = ...
    df['yy'] = ...

    upper_bound = ...
    lower_bound = ...

    long_trigger = ... 
    short_trigger = ...

    if graph == True:  
        fig = pgo.Figure(data=[pgo.Candlestick(x=df['timestamp'],
                                               open=df['open'], high=df['high'],
                                               low=df['low'], close=df['close'], line=dict(width=1)),

                               pgo.Line(x=df['timestamp'],
                                        y=df['zz'], line=dict(width=1)),

                               pgo.Line(x=df['timestamp'],
                                        y=df['yy'], line=dict(width=1)), ])

        ...  # show useful stuff
        ...  # show useful stuff

        fig.update_layout(xaxis_rangeslider_visible=False)
        fig.write_html('first_figure.html', auto_open=True)
        os.remove('first_figure.html')
    

def get_latest_data():
    """ get current price from (testnet!) websocket stream to avoid API rate limits """
    try:
        response = requests.get('http://localhost:4444/instrument?symbol=XBTUSD')
        data = response.json()[0]
        current_price = data['midPrice']   # maybe not the best idea
        current_low = data['low']
        current_high = data['high']

        return current_price, current_high, current_low

    except:
        raise Exception('lost connection!')


def determine_position_size(risk_factor, current_price, stop_level):
    pass


ATR_LENGTH = ...
ATR_MULT = ...
LENGTH = ...
CANDLES = ...
RISK = ...

# initialise glob vars
calculate_levels(LENGTH, CANDLES, ATR_MULT)

schedule.every().minute.at(":00").do(calculate_levels, LENGTH, CANDLES, ATR_MULT, graph=False)

while True:
    schedule.run_pending()
    time.sleep(1)
    
    close, high, low = get_latest_data()

    if ...:   # long condition
        trade = 'in_long'
        stop = lower_bound

    if ...:   # short condition
        trade = 'in_short'
        stop = upper_bound

    if trade == 'in_long' and lower_bound > stop:
        stop = lower_bound

    if trade == 'in_short' and upper_bound < stop:
        stop = upper_bound

    if trade == 'in_long' and low < stop:
        trade = 'none'

    if trade == 'in_short' and high > stop:
        trade = 'none'