var ws = new WebSocket("ws://127.0.0.1:8099/");

ws.addEventListener("open", () => {
  ws.send(JSON.stringify({
    operation: 1
  }));
});

ws.addEventListener("message", (e) => {
  var msg = JSON.parse(e.data);

  switch (msg.operation) {
    case 2:
      document.getElementById("thumbnail").src = msg.video.thumb;
      break;
  }
});
