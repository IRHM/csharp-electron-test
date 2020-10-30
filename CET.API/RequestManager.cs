using System.Net.Sockets;

namespace CET.API
{
  public class RequestManager
  {
    public static void Route(Socket client, string request) {
      client.Send(Server.CreateFrameFromString("Message recieved by router"));
    }
  }
}