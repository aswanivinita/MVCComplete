using _22JQueryAjax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22JQueryAjax.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDbContext db = new EmployeeDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllRecords()
        {
            return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Save(Employee employee)
        {
            if (employee.Id == 0)
                db.Employees.Add(employee);
            else
            {
                Employee emp = db.Employees.Find(employee.Id);
                emp.Name = employee.Name;
                emp.Salary = employee.Salary;
                db.Entry(emp).State = EntityState.Modified;
            }
            db.SaveChanges();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int id)
        {
            Employee emp = db.Employees.Find(id);
            db.Entry(emp).State = EntityState.Deleted;
            db.SaveChanges();
            return Json(new { Success = "success" }, JsonRequestBehavior.AllowGet);
        }
    }
}