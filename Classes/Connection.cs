using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SocketExperiment.Classes
{
    public class Connection : PersistentConnection
    {
        protected override System.Threading.Tasks.Task OnReceived(IRequest request, string connectionId, string data)
        {
            var t = new Thing {Id = 7, Name = data};
            return Connection.Broadcast(t);
        }
    }
}