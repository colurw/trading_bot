# trading_bot

Use `docker compose up` to run

### bitmex_streamer/

A containerised Node.js app for connecting to BitMEX's realtime API.  Allows for frequent requests without being rate-limited.

Built from https://github.com/BitMEX/api-connectors/tree/master/official-ws/delta-server

### indicator_public.py

Analyses recent price data and determines the boundaries that will trigger market entries and exits.  Redacted version.

### make_trades.py

Watches the realtime price stream and enacts a risk-adjusted trailing-stopped strategy with API calls to the market.

