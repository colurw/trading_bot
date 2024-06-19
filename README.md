# trading_bot

A work in progress...  use `docker compose up` to run

### bitmex_streamer/

A containerised Node.js app for connecting to BitMEX's realtime API.  Allows for frequent requests without being rate-limited.

Built from https://github.com/BitMEX/api-connectors/tree/master/official-ws/delta-server

### indicator_public.py

Downloads recent historic price data and calculates the boundaries that will trigger trade entries and exits.  Redacted version.

### make_trades.py

Watches the realtime price and enacts a risk-adjusted trading strategy by making API calls to the market.

