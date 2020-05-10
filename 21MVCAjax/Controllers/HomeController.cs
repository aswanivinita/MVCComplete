using _21MVCAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace _21MVCAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetDateTime()
        {
            Thread.Sleep(2000);
            return PartialView("_GetDateTime");
        }
        [HttpPost]
        public ContentResult Create(Employee employee)
        {
            Thread.Sleep(2000);
            return Content("<h2>Employee name is : " +employee.Name + " and salary is: " +employee.Salary +"</h2>");
        }
    }
}