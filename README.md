# trading_bot

A work in progress...

## bitmex_streamer/

A containerised Node.js app for connecting to BitMEX's realtime API.  Allows for frequent polling without being ratelimited.

Built from https://github.com/BitMEX/api-connectors/tree/master/official-ws/delta-server

`docker build --tag 'bitmex_streamer' .`

`docker run -p 127.0.0.1:4444:4444 bitmex_streamer`

`curl "http://localhost:4444/instrument?symbol=XBTUSD"`

## trading_algo.py

A long and short breakout-based strategy with trailing stops.

## to do...

Risk management() - auto-adjust bid sizes to reduce the degree of variance in returns and losses. 
