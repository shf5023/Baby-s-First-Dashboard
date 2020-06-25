using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Netflix_Dashboard_mk1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Hiya",
                url: "{controller}/{action}/{name}/{numTimes}"
            );
            routes.MapRoute(
                name: "OtherView",
                url: "{controller}/{action}",
                defaults: new { controller = "HelloWorld", action = "otherView"}
                );
        }
    }
}
