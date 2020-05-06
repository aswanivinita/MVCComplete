using _19FiltersDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19FiltersDemo.CustomFilters
{
    public class ActionFilter : IActionFilter
    {
        private Stopwatch timer;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();

            SessionManager.StoreInSession(filterContext, "OnActionExecuted - Time taken to execute action method is " +
                  timer.ElapsedMilliseconds );
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();

            SessionManager.StoreInSession(filterContext, "OnActionExecuting");
        }
    }
}