using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace HubClient.Web.Hubs
{
    public class DemoHub : Hub
    {
        public void MyMethod()
        {
            Clients.Caller.AlertMe("Hello World x2");
        }

        public void MyMethodWithParameters(string a)
        {
            Clients.All.AlertMe("Goodbye World");
        }

        public void MyMethodWithParameterComplex(MyDataType a)
        {
            Clients.All.AlertMe("Hello Complex World");
        }

        public override System.Threading.Tasks.Task OnConnected()
        {
            Debug.WriteLine("New connection : " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnDisconnected()
        {
            Debug.WriteLine("Disconnection : " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnReconnected()
        {
            Debug.WriteLine("Reconnection : " + Context.ConnectionId);
            return base.OnConnected();
        }
    }

    public class MyDataType
    {
        public string Id { get; set; }
    }
}