using _09EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDbContext db = new EmployeeDbContext();
        public ActionResult Index()
        {
           
            
            return View(db.Employees.ToList());
        }

        public ActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {

            return View();
        }



    }
}