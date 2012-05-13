using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4.Models;

namespace Mvc4.Controllers
{
    public class TicketController : Controller
    {
        //
        // GET: /Ticket/
        public ActionResult Toon()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nieuw()
        {


            var dataContext = new KlantDataContext();
            var klanten = from m in dataContext.Klants select m;
            if (klanten.Any())
                ViewBag.klanten = klanten.ToList();
            
            List<SelectListItem> items = new List<SelectListItem>();

            return View();
        }
    }
}
