using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sixeyed.SpecFlowItAll.Api.DelegatingHandlers;
using System.Web.Http;

namespace Sixeyed.SpecFlowItAll.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
            GlobalConfiguration.Configuration.MessageHandlers.Add(new ApiVersionHandler());
        }
    }
}
