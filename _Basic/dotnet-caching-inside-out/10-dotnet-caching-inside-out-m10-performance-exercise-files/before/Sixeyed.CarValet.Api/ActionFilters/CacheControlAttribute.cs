using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace Sixeyed.CarValet.Api.ActionFilters
{
    public class CacheControlAttribute : ActionFilterAttribute
    {
        public double MaxAgeSeconds { get; set; }
        public double SharedMaxAgeSeconds { get; set; }

        public bool Private { get; set; }
        public bool Public { get; set; }

        public bool MustRevalidate { get; set; }
        public bool ProxyRevalidate { get; set; }

        public bool NoCache { get; set; }
        public bool NoStore { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var response = actionExecutedContext.Response;
            //response.Headers.Vary.Add("Accept");
            var cacheControl = new CacheControlHeaderValue();
            if (MaxAgeSeconds > 0)
            {
                cacheControl.MaxAge = TimeSpan.FromSeconds(MaxAgeSeconds);
            }
            if (SharedMaxAgeSeconds > 0)
            {
                cacheControl.SharedMaxAge = TimeSpan.FromSeconds(SharedMaxAgeSeconds);
            }

            cacheControl.Private = Private;
            cacheControl.Public = Public;
            cacheControl.MustRevalidate = MustRevalidate;
            cacheControl.ProxyRevalidate = ProxyRevalidate;
            cacheControl.NoCache = NoCache;
            cacheControl.NoStore = NoStore;

            response.Headers.CacheControl = cacheControl;
        }
    }
}