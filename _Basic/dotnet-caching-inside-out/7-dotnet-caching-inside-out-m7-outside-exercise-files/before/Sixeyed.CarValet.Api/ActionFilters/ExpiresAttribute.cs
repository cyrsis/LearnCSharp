using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace Sixeyed.CarValet.Api.ActionFilters
{
    public class ExpiresAttribute : ActionFilterAttribute
    {
        public int Days { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //for a 304 we won't have content:
            if (actionExecutedContext.Response.Content != null)
            {
                actionExecutedContext.Response.Content.Headers.Expires = DateTimeOffset.Now + TimeSpan.FromDays(Days);
            }
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue();
        }
    }
}