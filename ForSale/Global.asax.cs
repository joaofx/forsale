using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages.Scope;
using System.Reflection;

namespace ForSale
{
    public class MvcApplication : System.Web.HttpApplication
    {
		protected void Application_BeginRequest()  
		{  
			var ob = typeof(AspNetRequestScopeStorageProvider).Assembly.GetType("System.Web.WebPages.WebPageHttpModule").GetProperty("AppStartExecuteCompleted",BindingFlags.NonPublic | BindingFlags.Static);  
			ob.SetValue(null, true, null);  
		}

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
