using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebProje.Models.DataContext;

namespace WebProje
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
