using HubClient.Web.Hubs;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HubClient.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alert(string id)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<DemoHub>();
            var context2 = GlobalHost.ConnectionManager.GetHubContext("DemoHub");

            context.Clients.All.AlertMe(id);

            return new EmptyResult();

        }
	}
}