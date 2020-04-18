using _13DbFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13DbFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDb2Entities db = new EmployeeDb2Entities();
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        //TODO : CReate, Edit, Delete , Details
    }
}