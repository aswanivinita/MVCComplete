using _18AuthenticationAndAuthorization.Models;
using _18AuthenticationAndAuthorization.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _18AuthenticationAndAuthorization.Controllers
{
    public class AccountsController : Controller
    {
        AuthDbContext db = new AuthDbContext();

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(AppUser user)
        {
            if(ModelState.IsValid)
            {
                db.AppUsers.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "Accounts");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginVM)
        {
            if(ModelState.IsValid)
            {
                AppUser appUser = db.AppUsers.Where(x => x.Email == loginVM.Email
                && x.Password == loginVM.Password).FirstOrDefault();

               
                if(appUser != null)
                {
                    //User is authentic
                    FormsAuthentication.SetAuthCookie(appUser.Name, loginVM.RememberMe);
                    //code to add the role to cookie
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                        1,
                        appUser.Name,
                        DateTime.Now,
                        DateTime.Now.AddMinutes(20),
                        loginVM.RememberMe,
                        appUser.Roles
                        );

                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                   
                    HttpContext.Response.Cookies.Add(cookie);

                    string returnUrl = Request.QueryString["ReturnUrl"];
                    if(returnUrl != null)
                    {
                        return Redirect(returnUrl);
                    }
                   
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.Error = "Invalid email and Password";

                
            }
            ViewBag.Error = "Invalid email and Password";
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}