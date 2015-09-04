using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SportsStore.Controllers
{
     
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Meine Daten";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontaktseite.";

            return View();
        }
        public ActionResult Preise()
        {
            ViewBag.Message = "Preise";

            return View();
        }
        public ActionResult Datenschutz()
        {
            ViewBag.Message = "Datenschutzerklärung";

            return View();
        }
        public ActionResult Impressum()
        {
            ViewBag.Message = "Impressum";

            return View();
        }
        public ActionResult AGB()
        {
            ViewBag.Message = "AGB";

            return View();
        }
      
    }
}