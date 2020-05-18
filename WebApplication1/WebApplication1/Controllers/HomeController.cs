using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        public ActionResult Branch1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Branch2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Branch3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Master()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CI_1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}