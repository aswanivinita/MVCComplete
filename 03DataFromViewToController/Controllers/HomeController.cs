using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Data from query string
        //http://localhost:59331/home/fullname?fn=ram&ln=sharma

        public ActionResult FullName(string fn, string ln)
        {
            string fullName = fn + " " + ln;
            return View(model:fullName) ;


        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return View(sum);
        }



    }
}