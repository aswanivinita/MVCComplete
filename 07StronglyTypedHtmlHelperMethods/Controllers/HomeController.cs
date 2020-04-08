using _07StronglyTypedHtmlHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07StronglyTypedHtmlHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        
        [HttpPost]
        public ActionResult Index(Student student)
        {
            return View();
        }
    }
}