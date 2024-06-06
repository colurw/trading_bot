A containerised Node-JS for connecting to BitMEX's realtime API.  Allows frequent updates without being ratelimited.

Built from https://github.com/BitMEX/api-connectors/tree/master/official-ws/delta-server

`docker build --tag 'bitmex_streamer' .`
`docker run -p 127.0.0.1:4444:4444 bitmex_streamer`
`curl "http://localhost:4444/instrument?symbol=XBTUSD"`
