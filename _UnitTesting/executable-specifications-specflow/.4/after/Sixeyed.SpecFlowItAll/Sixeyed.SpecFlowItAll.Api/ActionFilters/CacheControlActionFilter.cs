using System.Net.Http.Headers;
using System.Web.Http.Filters;
using System.Xml;

namespace Sixeyed.SpecFlowItAll.Api.ActionFilters
{
    public class CacheControlAttribute : ActionFilterAttribute
    {
        public string MaxAgeDuration { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            var maxAge = XmlConvert.ToTimeSpan(MaxAgeDuration);
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = maxAge
            };
        }
    }
}