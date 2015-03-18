using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Part1_FirstHub
{
    //Step1-Create a hubClass and call it 'chatHub'
    //step2-Go to startup.cs and write this inside the method - app.MapSignalR();
    //step3-Go press F5 and type this url - 'localhost:1111/signalr/hubs'

    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.hello();
        }
    }
}