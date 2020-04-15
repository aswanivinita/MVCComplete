using _10DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10DataAnnotations.Controllers
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
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }


        public ActionResult Edit(int id)
        {
            Student student = db.Students.Find(id);

            if (student != null)
            {
                return View(student);

            }


            return RedirectToAction("errorPage", "error");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }





    }
}