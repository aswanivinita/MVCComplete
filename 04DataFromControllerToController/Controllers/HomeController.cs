using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04DataFromControllerToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo1(string city, string pincode)
        {
            TempData["City"] = city;
            TempData["Pincode"] = pincode;
            return RedirectToAction("Demo2");
        }

        public ActionResult Demo2()
        {
            // TempData.Keep();
            TempData.Keep("City");
            return View();
        }

        public ActionResult Demo3()
        {
            return View();
        }

        public ActionResult Demo4()
        {
            return View();
        }

        public ActionResult CallTestEmployee()
        {
            var employee = new { Id = 123, Name = "Ram", Department = "HR" };
            TempData["Data"] = employee;
            return RedirectToAction("Test", "Employee");
        }

    }
}