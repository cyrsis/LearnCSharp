using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Steps.Spec
{
    public abstract class ApiStepBase
    {
        protected string RequestUrl
        {
            get { return ScenarioContext.Current.Get<string>("RequestUrl"); }
            set { ScenarioContext.Current.Set<string>(value, "RequestUrl"); }
        }

        protected Dictionary<string, string> RequestHeaders
        {
            get { return ScenarioContext.Current.Get<Dictionary<string, string>>("RequestHeaders"); }
            set { ScenarioContext.Current.Set<Dictionary<string, string>>(value, "RequestHeaders"); }
        }

        protected HttpResponseMessage ResponseMessage
        {
            get { return ScenarioContext.Current.Get<HttpResponseMessage>("ResponseMessage"); }
            set { ScenarioContext.Current.Set<HttpResponseMessage>(value, "ResponseMessage"); }
        }

        protected string ResponseBody
        {
            get { return ScenarioContext.Current.Get<string>("ResponseBody"); }
            set { ScenarioContext.Current.Set<string>(value, "ResponseBody"); }
        }

        protected dynamic Response
        {
            get { return ScenarioContext.Current.Get<dynamic>("Response"); }
            set { ScenarioContext.Current.Set<dynamic>(value, "Response"); }
        }

        protected async Task GetResponse()
        {
            ResponseMessage = null;
            ResponseBody = null;
            Response = null;
            using (var client = new HttpClient())
            {
                foreach (var header in RequestHeaders)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                ResponseMessage = await client.GetAsync(RequestUrl);
                ResponseBody = await ResponseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(ResponseBody))
                {
                    Response = JsonConvert.DeserializeObject<dynamic>(ResponseBody);
                }
            }
        }
    }
}
