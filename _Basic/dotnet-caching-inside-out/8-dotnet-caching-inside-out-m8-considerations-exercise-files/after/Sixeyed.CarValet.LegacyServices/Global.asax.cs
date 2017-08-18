using Sixeyed.CarValet.LegacyServices.CachePreloaders;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace Sixeyed.CarValet.LegacyServices
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var preloadQuotePrices = bool.Parse(ConfigurationManager.AppSettings["PreloadQuotePricesOnStartup"]);
            if (preloadQuotePrices)
            {
                Task.Factory.StartNew(() => QuotePricePreloader.Run());
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}