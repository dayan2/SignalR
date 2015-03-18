using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;
//Step1-Create a hubClass and call it 'chatHub'
//step2-Go to startup.cs and write this inside the method - app.MapSignalR();
//step3-Go press F5 and type this url - 'localhost:1111/signalr/hubs'
//step4-Implement those method in the 'ChatHub' class
//step5-Create a Html page - 'chat.html'
//step6-Go to the nuget and install - 'SignalR Utilities' extension
//step7-To install 'SignalR Utilities' properly..... u need to go to the Command prompt and Find this file in ur nuget folder - 'Microsoft.AspNet.SignalR.Utils.2.1.1' and there will be execute file called - 'signalr.exe' - run this file like this way in the prompt -  
// signalr.exe ghp /url:http://localhost:26138/ - (type this in command prompt to get the server.js file, when u get it copy it and paste it in ur VisualStudio folder)
        
namespace SignalR_New
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        //Creating Methods
        public void SendMessage(string message)
        {
            var msg = string.Format("{0}  - {1} ", Context.ConnectionId, message);
            Clients.All.newMessage(msg);
        }

        //Joining a Group - this will make sure only people belong to the group will get the messages when they press the '#sendMessageToRoom' button in the html
        public void JoinRoom(string room)
        {
            //Pushing Data into a Group
            Groups.Add(Context.ConnectionId, room);
        }

        //Sending messages to the Client - if the client has a room, message will be shown just for the users belong to that room(to use this method client has to type a room in the textBox)
        public void SendMessageToRoom(string room, string message)
        {
            var msg = string.Format("{0}  {1} ", Context.ConnectionId, message);
            Clients.Group(room).newMessage(msg);
        }

        //buit-in methods overriding - this method will send the status(Connected/Disconnected) to the 'SendMonitoringData()'
        public override Task OnConnected()
        {
            SendMonitoringData("Connected", Context.ConnectionId);
            return base.OnConnected();
        }

        ////buit-in methods overriding - this method will send the status(Connected/Disconnected) to the 'SendMonitoringData()'
        public override Task OnDisconnected(bool stopCalled)
        {
            SendMonitoringData("Disconnected", Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }

        //buit-in methods overriding 
        public override Task OnReconnected()
        {
            SendMonitoringData("Reconnected", Context.ConnectionId);
            return base.OnReconnected();
        }

        //Through this method any Client-side connection can map to the 'MonitorHub' as well
        private void SendMonitoringData(string eventType, string connection)
        {
            //need to create a 'hubClass' with this name - 'MonitorHub'
            var context = GlobalHost.ConnectionManager.GetHubContext<MonitorHub>();

            //sending the status(Connected/Disconnected) to Client-side
            context.Clients.All.newEvent(eventType, connection);
        }
    }
}