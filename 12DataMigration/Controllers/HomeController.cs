using _12DataMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12DataMigration.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContext db = new StudentDbContext();
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Create()
        {
           
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return View();
        }
    }
}