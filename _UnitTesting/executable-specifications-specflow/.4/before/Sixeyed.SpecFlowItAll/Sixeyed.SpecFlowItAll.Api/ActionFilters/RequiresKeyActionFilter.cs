using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Sixeyed.SpecFlowItAll.Api.ActionFilters
{
    public class RequiresKeyAttribute : ActionFilterAttribute
    {
        public Permission Permission { get; set; }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var authorized = false;
            var apiKeyHeader = actionContext.Request.Headers.FirstOrDefault(x => x.Key == "x-api-key");
            if (apiKeyHeader.Value != null)
            {
                var apiKey = apiKeyHeader.Value.FirstOrDefault();
                authorized = (ConfigurationManager.AppSettings["adminApiKey"] == apiKey) ||
                             (Permission == Permission.Read && ConfigurationManager.AppSettings["websiteApiKey"] == apiKey);
            }
            if (!authorized)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
            }
            else
            {
                base.OnActionExecuting(actionContext);
            }
        }
    }

    [Flags]
    public enum Permission
    {
        Read = 1,
        Update = 2
    }
}