using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GriffDesk.Web.Controllers
{
    public class TicketController : Controller
    {
        //
        // GET: /Ticket/
        public ActionResult Index(Guid id)
        {
            return View(id);
        }
	}
}