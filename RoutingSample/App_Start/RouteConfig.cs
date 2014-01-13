using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Privacy_route",
            url: "Privacy",
            defaults: new { controller = "Home", action = "Privacy"}
            );

            routes.MapRoute(
            name: "404_route",
            url: "404",
            defaults: new { controller = "Home", action = "Error404" }
            );


            routes.MapRoute(
            name: "Category_product",
            url: "Products/ByCategory/{category}",
            defaults: new { controller = "Products", action = "Category",category="All" }
            );


            routes.MapRoute(
            name: "Details_product",
            url: "Products/{productCode}",
            defaults: new { controller = "Products", action = "Details" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
