using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ASP.NET_MVC
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/js");
            bundle.Include("~/Content/Js/JavaScript.js", "~/Content/Js/JavaScript1.js", "~/Content/Js/JavaScript2.js");
            bundles.Add(bundle);

            //To render in view , add this line in view
            //@Scripts.Render("~/bundles/js");

            //Bundling will not work in debug mode untill we do this
            BundleTable.EnableOptimizations = true;

            //IncludeDirectory method is used to include all files(Based on search pattern) from a folder to bundle
            //like
            //bundles.Add(new ScriptBundle("~/bundles/js").IncludeDirectory("~/Content/Js", "*.js"));
        }
    }
}