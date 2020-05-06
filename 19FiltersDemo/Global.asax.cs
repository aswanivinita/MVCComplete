using _19FiltersDemo.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _19FiltersDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            GlobalFilters.Filters.Add(new ActionFilter());
            GlobalFilters.Filters.Add(new ResultFilter());
            GlobalFilters.Filters.Add(new AuthenticationFilter());
            GlobalFilters.Filters.Add(new AuthorizationFilter());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
