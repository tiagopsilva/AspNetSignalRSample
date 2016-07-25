using Microsoft.AspNet.SignalR;

namespace AspNetSignalRSample.Hubs
{
    public class ChatHub : Hub
    {
        public void BroadcastMessage(string message)
        {
            Clients.All.writeMessage(message);
        }
    }
}