using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06HtmlHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string married, bool html, bool cSS, bool javaScript, bool cSharp, string branch,
            string description, string secretKey, string email, string password)
        {
            //Save this data to DataBase 
            return View();
        }
    }
}