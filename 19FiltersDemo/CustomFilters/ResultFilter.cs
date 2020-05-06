using _19FiltersDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19FiltersDemo.CustomFilters
{
    public class ResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            SessionManager.StoreInSession(filterContext, "OnResultExecuted");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            SessionManager.StoreInSession(filterContext, "OnResultExecuting");
        }
    }
}