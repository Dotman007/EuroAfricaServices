using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Euro_Africa.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult StudentGallery()
        {
            return View();
        }
        public ActionResult PartnerGallery()
        {
            return View();
        }
        public ActionResult UniversityGallery()
        {
            return View();
        }
        public ActionResult Humanities()
        {
            return View();
        }
        public ActionResult HostelMolo()
        {
            return View();
        }
        public ActionResult Polonous()
        {
            return View();
        }
        public ActionResult Wasp()
        {
            return View();
        }
    }
}