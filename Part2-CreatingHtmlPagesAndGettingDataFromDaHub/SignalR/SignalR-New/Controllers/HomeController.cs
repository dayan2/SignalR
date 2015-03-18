using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR_New.Controllers
{
    public class HomeController : Controller
    {
        //Step1-Create a hubClass and call it 'chatHub'
        //step2-Go to startup.cs and write this inside the method - app.MapSignalR();
        //step3-Go press F5 and type this url - 'localhost:1111/signalr/hubs'
        //step4-Implement those method in the 'ChatHub' class
        //step5-Create a Html page - 'chat.html'
        //step6-Go to the nuget and install - 'SignalR Utilities' extension
        //step7-To install 'SignalR Utilities' properly..... u need to go to the Command prompt and Find this file in ur nuget folder - 'Microsoft.AspNet.SignalR.Utils.2.1.1' and there will be execute file called - 'signalr.exe' - run this file like this way in the prompt -  
        // signalr.exe ghp /url:http://localhost:26138/ - (type this in command prompt to get the server.js file, when u get it copy it and paste it in ur VisualStudio folder)
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}