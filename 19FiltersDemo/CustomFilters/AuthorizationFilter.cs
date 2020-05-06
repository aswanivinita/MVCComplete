using _19FiltersDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19FiltersDemo.CustomFilters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            SessionManager.StoreInSession(filterContext, "OnAuthorization");
        }
    }
}