using System.Web.Mvc;
using System.Web.Routing;

namespace ForSale
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Tags",
                "{tag}",
                new { controller = "Product", action = "Index" }
            );

            routes.MapRoute(
                "Products",
                "p/{title}",
                new { controller = "Product", action = "Show", title= UrlParameter.Optional }
            );

            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new { controller = "Product", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
