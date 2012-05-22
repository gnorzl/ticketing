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
        public ActionResult Toon(int id)
        {


            var dataContext = new TicketDataContext();
            Ticket ticket = (from m in dataContext.Tickets where m.id.Equals(id) select m).Single();
            ViewBag.ticket = ticket;

            var dataContextGebruiker = new GebruikerDataContext();
            Gebruiker gebruiker = (from m in dataContextGebruiker.Gebruikers where m.emailadres.Equals(ticket.gebruikerid) select m).Single();
            ViewBag.gebruiker = gebruiker;

            var dataContextKlant = new KlantDataContext();
            Klant klant = (from m in dataContextKlant.Klants where m.id.Equals(ticket.klantid) select m).Single();
            ViewBag.klant = klant;

            //    klant.id = 2;
        
        //    ViewBag.Gearlink = "/Klant/Wijzig?id=" + klant.id;
            return View(ticket);



            //ViewBag.id = id;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NieuwTicket(int klant) {



            var dataContext = new TicketDataContext();
            Ticket t = new Ticket();
            t.klantid = klant;
            t.gebruikerid = User.Identity.Name;

    
            dataContext.Tickets.InsertOnSubmit(t);
            dataContext.SubmitChanges();
            //return View("Index");
          //  return RedirectToAction("Toon?id=" + t.id.ToString(),"Ticket");
         //   Toon(k.id);
//            return View("Toon");









            //return View();
            return RedirectToAction("Toon", new { id = t.id });
            //return Red
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
