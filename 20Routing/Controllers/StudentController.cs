using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20Routing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index( int id = 1)
        {
            
            switch (id)
            {
                case 1:
                    ViewBag.Name = "Ram";
                    break;
               
                case 2:
                    ViewBag.Name = "Ajay";
                    break;
               
                case 3:
                    ViewBag.Name = "Neha";
                    break;

                default:
                    ViewBag.Name = "Invalid";
                    break;
            }
            return View();
        }

        [Route("StudentDetails/{id}")]
        public ActionResult Details(int id = 1)
        {
            switch (id)
            {
                case 1:
                    ViewBag.Name = "Ram";
                    break;

                case 2:
                    ViewBag.Name = "Ajay";
                    break;

                case 3:
                    ViewBag.Name = "Neha";
                    break;

                default:
                    ViewBag.Name = "Invalid";
                    break;
            }

            return View();
        }
    }
}