using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0202DataFromControllerToView1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string s1 = "Data using View Data";
            string s2 = "Data using Temp Data ";
            string s3 = "Data using View Bag";
            string s4 = "Data using Model";
            int num = 100;


            ViewData["Data"] = s1;
            TempData["Data"] = s2;
            ViewBag.Data = s3;

            ViewData["Number"] = num;
            ViewBag.Number = num;


            return View(model:s4);
        }
    }
}