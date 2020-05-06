using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18AuthenticationAndAuthorization.Controllers
{
    [Authorize]
    public class SecuredController : Controller
    {
        // GET: Secured
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Secured1()
        {
            return View();
        }

        public ActionResult Secured2()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Secured3()
        {
            return View();
        }
    }
}