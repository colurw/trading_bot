import requests
import pandas as pd
import plotly.graph_objects as pgo
import time
import sys


class Indicator():
    def __init__(self):
        self.long_trigger = 0.0
        self.short_trigger = 0.0
        self.upper_bound = 0.0
        self.lower_bound = 0.0


    def wwma(self, pd_series, period):
        """ w. wilder's EMA """
        
        return pd_series.ewm(alpha=1/period, adjust=False, ignore_na=True).mean()


    def atr(self, df, atr_length):
        """ average true range (for columns with latest values at bottom) """
        df_high, df_low, df_prev_close = df['high'], df['low'], df['close'].shift()
        df_tr = [df_high- df_low, df_high - df_prev_close, df_low - df_prev_close]
        df_tr = [tr.abs() for tr in df_tr]
        df_tr = pd.concat(df_tr, axis=1).max(axis=1)
        df_atr = self.wwma(df_tr, atr_length)
        
        return df_atr


    def get_historic_data(self, data_length, buckets='1h', resampled_buckets=False):
        """ get 1hr bucketed historic OHLC prices from API and return as a dataframe """
        attempts = 0
        while True:
            try:
                response = requests.get(f'https://www.bitmex.com/api/v1/trade/bucketed?binSize={buckets}&partial=false&symbol=XBTUSD&count={data_length}&reverse=true').json()
                break

            except:
                time.sleep(5)
                if attempts == 3:
                    message('get_historic_data failed')   # type: ignore  
                    sys.exit()

        df = pd.DataFrame.from_dict(response)
        df = df.iloc[::-1]  # reverse dataframe

        df['hour'] = df.timestamp.str[11:13]
        df['end_time_utc'] = pd.to_datetime(df['timestamp'], utc=False)
        df = df.set_index('end_time_utc')
        df = df.drop(columns=['vwap', 'lastSize', 'turnover', 
                            'homeNotional', 'foreignNotional', 
                            'trades', 'symbol', 'timestamp'], axis=1)

        if resampled_buckets:
                
            ohlc_dict = {'open':'first', 'high':'max', 'low':'min', 'close': 'last', 'hour': 'first'}
            df2 = df.resample(resampled_buckets, offset=1).apply(ohlc_dict).dropna(how='any')
            df2.index.names = ['start_time_utc']
            df2 = df2.drop(columns=['hour'], axis=1) 

            print(df.head(12))
            print(df2.head(3))

            return df2
        
        return df


    def useful_stuff():
        ...

        return ...


    def calculate(self, data_length=20, candles='1h', atr_length=14, atr_multiplier=3, graph=False):
        """ generates the price levels that trigger buy/sell/exit api calls if crossed """
        df = self.get_historic_data(data_length, candles)

        # reverse dataframe
        df = df.iloc[::-1]

        # calculate significant levels
        df['ATR'] = self.atr(df, atr_length)
        df['xx'] = ...
        df['yy'] = ...
        df['zz'] = ...

        self.upper_bound = ...
        self.lower_bound = ...

        self.long_trigger = ... 
        self.short_trigger = ...

        if graph == True:  
            fig = pgo.Figure(data=[pgo.Candlestick(x=df['timestamp'],
                                                open=df['open'], high=df['high'],
                                                low=df['low'], close=df['close'], line=dict(width=1)),

                                   pgo.Line(x=df['timestamp'],
                                            y=df['yy'], line=dict(width=1)),

                                   pgo.Line(x=df['timestamp'],
                                            y=df['zz'], line=dict(width=1)), ])

            fig.update_layout(xaxis_rangeslider_visible=False)
            fig.write_image("trading_algorithm/persisted/graph.png") 
