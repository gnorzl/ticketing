using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4.Models;

namespace Mvc4.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categorie()
        {

            var dataContext = new ProductCategorieDataContext();
            var categories = from m in dataContext.ProductCategories select m;
            if (categories.Any())
                ViewBag.categories = categories.ToList();
            return View();

        }
    }
}
