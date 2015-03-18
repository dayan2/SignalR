using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part1_FirstHub.Controllers
{
    public class HomeController : Controller
    {
        //Step1-Create a hubClass and call it 'chatHub'
        //step2-Go to startup.cs and write this inside the method - app.MapSignalR();
        //step3-Go press F5 and type this url - 'localhost:1111/signalr/hubs'
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