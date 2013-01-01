using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat
{
    using Microsoft.AspNet.SignalR;

    public class ChatConnection : PersistentConnection
    {
        protected override System.Threading.Tasks.Task OnReceivedAsync(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }

        protected override System.Threading.Tasks.Task OnConnectedAsync(IRequest request, string connectionId)
        {
            return Connection.Broadcast(connectionId + " joined the room");
        }

        protected override System.Threading.Tasks.Task OnDisconnectAsync(IRequest request, string connectionId)
        {
            return Connection.Broadcast(connectionId + " left the room");
        }
    }
}