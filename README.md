# trading_bot

A work in progress...

### bitmex_streamer/

A containerised Node.js app for connecting to BitMEX's realtime API.  Allows for frequent updates without being ratelimited.

Built from https://github.com/BitMEX/api-connectors/tree/master/official-ws/delta-server

`docker build --tag 'bitmex_streamer' .`

`docker run -p 127.0.0.1:4444:4444 bitmex_streamer`

`curl "http://localhost:4444/instrument?symbol=XBTUSD"`

### calculate_levels_public.py

Downloads historic price data and calculates significant price levels.  Redacted version.

### make_trades.py

An automated long & short trading strategy based on significant levels and trailing stops.

### To do...

Risk management - auto-adjust bid sizes to reduce the degree of variance in returns and losses. 
Send market orders using bitmex client()
