using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4.Models;

namespace Mvc4.Controllers
{
    public class GebruikerController : Controller
    {
        //
        // GET: /Gebruiker/

        public ActionResult Index()
        {
            ViewBag.klanten = "";
          
            var dataContext = new GebruikerDataContext();
            var gebruikers = from m in dataContext.Gebruikers select m;
            if (gebruikers.Any())
                ViewBag.gebruikers = gebruikers.ToList();
            return View();
        }

    }
}
