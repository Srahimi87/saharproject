using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace saharproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "With a myODEON membership you can enjoy a faster, better booking experience, receive exclusive member offers, and so much more..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact Us .";

            return View();
        }
    }
}