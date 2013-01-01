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
    }
}