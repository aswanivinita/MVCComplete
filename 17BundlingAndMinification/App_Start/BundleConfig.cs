using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace _17BundlingAndMinification.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-3.4.1.min.js")
                .Include("~/scripts/bootstrap.min.js")
                .Include("~/scripts/MyJs1.js")
                .Include("~/scripts/MyJs2.js")
                );

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/bootstrap.min.css")
                .Include("~/content/site.css")
                .Include("~/content/Style1.css")
                .Include("~/content/Style2.css")
                );

            BundleTable.EnableOptimizations = true;

        }
    }
}