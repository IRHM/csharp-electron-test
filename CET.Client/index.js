var ws = new WebSocket("ws://127.0.0.1:8099/");

ws.addEventListener("open", () => {
  ws.send(JSON.stringify({
    hello: true
  }));
});
