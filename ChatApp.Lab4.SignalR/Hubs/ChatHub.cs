using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Lab4.SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public string GetConnectionId() => Context.ConnectionId;
    }
}