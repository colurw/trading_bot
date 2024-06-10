import requests
import pandas as pd
import plotly.graph_objects as pgo
import os


def wwma(pd_series, period):
    """ w. wilder's EMA returned as Pandas Series """
    
    return pd_series.ewm(alpha=1/period, adjust=False, ignore_na=True).mean()


def atr(df, atr_length):
    """ average true range (for columns with latest values at bottom) returned as Pandas Series """
    df_high, df_low, df_prev_close = df['high'], df['low'], df['close'].shift()
    df_tr = [df_high- df_low, df_high - df_prev_close, df_low - df_prev_close]
    df_tr = [tr.abs() for tr in df_tr]
    df_tr = pd.concat(df_tr, axis=1).max(axis=1)
    df_atr = wwma(df_tr, atr_length)
    
    return df_atr


def useful_stuff():
    ...

    return ...


def calculate_levels(data_length, candles, atr_length, atr_multiplier, graph=True):

    # glob vars as schedule() can't handle returned data
    global long_trigger, short_trigger, upper_bound, lower_bound

    # get bucketed historic prices from API and load into dataframe
    response = requests.get(f'https://www.bitmex.com/api/v1/trade/bucketed?binSize={candles}&partial=false&symbol=XBTUSD&count={data_length}&reverse=true')
    recent_data = response.json()
    df = pd.DataFrame.from_dict(recent_data)
    df['hour'] = df.timestamp.str[11:13]
    df = df.drop(columns=['vwap', 'lastSize', 'turnover', 
                          'homeNotional', 'foreignNotional', 
                          'trades', 'symbol'], axis=1)
    
    # reverse dataframe
    df = df.iloc[::-1]

    # calculate significant levels
    df['ATR'] = atr(df, atr_length)
    df['xx'] = ...
    df['yy'] = ...
    df['zz'] = ...

    upper_bound = ...
    lower_bound = ...

    long_trigger = ... 
    short_trigger = ...

    if graph == True:  
        fig = pgo.Figure(data=[pgo.Candlestick(x=df['timestamp'],
                                               open=df['open'], high=df['high'],
                                               low=df['low'], close=df['close'], line=dict(width=1)),

                               pgo.Line(x=df['timestamp'],
                                        y=df['yy'], line=dict(width=1)),

                               pgo.Line(x=df['timestamp'],
                                        y=df['zz'], line=dict(width=1)), ])

        ...  # show useful stuff
        ...  # show useful stuff

        fig.update_layout(xaxis_rangeslider_visible=False)
        fig.write_html('first_figure.html', auto_open=True)
        os.remove('first_figure.html')
    
    