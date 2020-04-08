using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05LayoutsAndPartialViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }


        public ActionResult ContactUs()
        {
            return View();
        }

        [ChildActionOnly]
        

        public ActionResult GetTeachers()
        {
            List<string> names = new List<string>();

            names.Add("Ramya");
            names.Add("Nidhi");
            names.Add("Sumit");
            names.Add("Ajay");
            
            
            return PartialView("_GetTeachers",names);
        }

        [NonAction]
        public string GetCurrentDate()
        {
            return DateTime.Now.ToString();
        }


    }
}