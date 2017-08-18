using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace Sixeyed.CarValet.Api.ActionFilters
{
    public class ExpiresAttribute : ActionFilterAttribute
    {
        public int Seconds { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //for a 304 we won't have content:
            var response = actionExecutedContext.Response;
            if (response.Content != null)
            {
                response.Content.Headers.Expires = DateTimeOffset.Now + TimeSpan.FromSeconds(Seconds);
                response.Headers.Vary.Add("Accept");
            }
            response.Headers.CacheControl = new CacheControlHeaderValue();
        }
    }
}