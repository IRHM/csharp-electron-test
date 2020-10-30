using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CET.API
{
  public class RequestManager
  {
    public static void Route(Socket client, string request) {
      var req = JObject.Parse(request);

      switch (req["operation"].Value<int>())
      {
        case 1:
          client.Send(Server.CreateFrameFromString(JsonConvert.SerializeObject(new {
            operation = 2,
            video = new {
              thumb = "/home/me/Casterr/Thumbs/02.09.2020 - 05.34.38.mp4.png"
            }
          })));
          break;
      }
    }
  }
}