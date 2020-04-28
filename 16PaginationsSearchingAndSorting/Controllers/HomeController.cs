using _16PaginationsSearchingAndSorting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace _16PaginationsSearchingAndSorting.Controllers
{
    public class HomeController : Controller
    {

        EmployeeDbContext db = new EmployeeDbContext();
        public ActionResult Index(string searchString,string sortOrder= "name_asc", int page = 1)
        {
            const int pageSize = 5;
            ViewBag.SearchString = searchString;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.Page = page;
            ViewBag.NameSort = sortOrder == "name_asc" ? "name_dsc" : "name_asc";
            ViewBag.SalarySort = sortOrder == "salary_asc" ? "salary_dsc" : "salary_asc";
            ViewBag.DepartmentSort = sortOrder == "dept_asc" ? "dept_dsc" : "dept_asc";
            List<Employee> employeeList = new List<Employee>();

            if (string.IsNullOrEmpty(searchString))
                employeeList = db.Employees.ToList();
            else
                employeeList = db.Employees.Where(employee => employee.Name.Contains(searchString)).ToList();

            switch (sortOrder)
            {
                case "name_asc":
                    employeeList = employeeList.OrderBy(emp => emp.Name).ToList();
                    break;
                case "name_dsc":
                    employeeList = employeeList.OrderByDescending(emp => emp.Name).ToList();
                    break;
                case "salary_asc":
                    employeeList = employeeList.OrderBy(emp => emp.Salary).ToList();
                    break;
                case "salary_dsc":
                    employeeList = employeeList.OrderByDescending(emp => emp.Salary).ToList();
                    break;
                case "dept_asc":
                    employeeList = employeeList.OrderBy(emp => emp.Department).ToList();
                    break;
                case "dept_dsc":
                    employeeList = employeeList.OrderByDescending(emp => emp.Department).ToList();
                    break;
                default:
                    employeeList = employeeList.OrderBy(emp => emp.Name).ToList();
                    break;
            }



            return View(employeeList.ToPagedList(page, pageSize));
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
            Employee e = db.Employees.Find(Id);


            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("Index");
        }


        public ActionResult Details(int Id)
        {
            Employee e = db.Employees.Find(Id);


            return View(e);
        }

        public ActionResult Delete(int Id)
        {
            Employee e = db.Employees.Find(Id);

            db.Entry(e).State = EntityState.Deleted;
            db.SaveChanges();


            return RedirectToAction("Index");
        }
    }



}