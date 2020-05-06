using _19FiltersDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Filters;

namespace _19FiltersDemo.CustomFilters
{
    public class AuthenticationFilter : IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            SessionManager.StoreInSession(filterContext, "OnAuthentication");
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            SessionManager.StoreInSession(filterContext, "OnAuthenticationChallenge");
        }
    }
}