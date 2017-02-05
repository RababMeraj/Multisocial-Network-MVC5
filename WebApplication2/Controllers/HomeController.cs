using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
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
        public ActionResult SignIn()
        {
            ViewBag.Message = "Your Sign In.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your application Login page.";

            return View();
        }
        public ActionResult policy()
        {
            ViewBag.Message = "Terms and conditions";

            return View();
        }
        public ActionResult Home()
        {
            ViewBag.Message = "Home";

            return View();
        }
        public ActionResult msg()
        {
            ViewBag.Message = "Terms and conditions";

            return View();
        }
        public ActionResult noti()
        {
            ViewBag.Message = "Terms and conditions";

            return View();
        }
        public ActionResult sett()
        {
            ViewBag.Message = "Terms and conditions";

            return View();
        }
        public ActionResult Profile()
        {
            ViewBag.Message = "Your profile";

            return View();
        }
    }
}