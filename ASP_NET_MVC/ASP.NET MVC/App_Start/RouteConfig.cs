using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
            //Part 19 - conventional routing
            //We can't have diff route for same action method but we can have same route for diff action method
            routes.MapRoute(
                name: "AllEmployees",
                url: "employees",
                defaults: new { controller = "Home", action = "GetAllEmplyees", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Employee",
                url: "employees/{id}",
                defaults: new { controller = "Home", action = "GetEmplyee", id = UrlParameter.Optional }
            );
            */

            /*
            //Part 20 - Attributes Routing
            routes.MapMvcAttributeRoutes();
            */

            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
