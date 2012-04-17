using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4.Models;

namespace Mvc4.Controllers
{
    public class KlantController : Controller
    {
        //
        // GET: /Klant/

        public ActionResult Index()
        {
            var dataContext = new KlantDataContext();
            var klanten = from m in dataContext.Klants
                          select m;
            return View(klanten);
        }

        public ActionResult Toon(int? id)
        {
            var dataContext = new KlantDataContext();
            Klant klant = (from m in dataContext.Klants where m.id.Equals(id) select m).Single();
            ViewBag.klant = klant;
        //    klant.id = 2;
            Klant klant2 = new Klant();
            klant2.voornaam = "joske";
            dataContext.Klants.InsertOnSubmit(klant2);
            dataContext.SubmitChanges();
            ViewBag.Gearlink = "/Klant/Wijzig?id=" + klant.id;
            return View(klant);
            
        }
        public ActionResult Wijzig(int? id)
        {
            var dataContext = new KlantDataContext();
            Klant klant = (from m in dataContext.Klants where m.id.Equals(id) select m).Single();
            ViewBag.klant = klant;
            //    klant.id = 2;
            
            return View(klant);
            
        }
        public ActionResult Zoek(string zoek)
        {
            ViewBag.klanten = "";
            if (zoek == null)
            {
                zoek = "";
            }
            var dataContext = new KlantDataContext();
            var klanten = from m in dataContext.Klants where m.voornaam.Contains(zoek) || m.achternaam.Contains(zoek) || m.straat.Contains(zoek) select m;
            if(klanten.Any())
            ViewBag.klanten = klanten.ToList();
            return View();
        }

        public ActionResult Insert(string voornaam, string achternaam, string bedrijf,string straat, string nummer, string postcode, string gemeente, string land, string telefoonnummer, string email)
        {
            var dataContext = new KlantDataContext();
            Klant k = new Klant();
            k.voornaam = voornaam;
            k.achternaam = achternaam;
            k.bedrijf = bedrijf;
            k.straat = straat;
            k.nummer = nummer;
            k.postcode = postcode;
            k.gemeente = gemeente;
            k.land = land;
            k.telefoonnummer = telefoonnummer;
            k.email = email;
            dataContext.Klants.InsertOnSubmit(k);
            dataContext.SubmitChanges();
            //return View("Index");
            //return RedirectToAction("Toon?id=" + k.id.ToString(),"Klant");
            Toon(k.id);
            return View("Toon");
            
        }

        public ActionResult Update(int id, string voornaam, string achternaam, string bedrijf, string straat, string nummer, string postcode, string gemeente, string land, string telefoonnummer, string email)
        {
            var dataContext = new KlantDataContext();
            Klant k = (from m in dataContext.Klants where m.id.Equals(id) select m).Single();
            k.voornaam = voornaam;
            k.achternaam = achternaam;
            k.bedrijf = bedrijf;
            k.straat = straat;
            k.nummer = nummer;
            k.postcode = postcode;
            k.gemeente = gemeente;
            k.land = land;
            k.telefoonnummer = telefoonnummer;
            k.email = email;
            dataContext.SubmitChanges();
            Toon(k.id);
            return View("Toon");

        }


        public ActionResult Nieuw()
        {
            return View();
        }
    }
}