using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Steps.Api
{
    public abstract class ApiStepBase : StepBase
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

        protected Dictionary<string, object> RequestBodyProperties
        {
            get { return ScenarioContext.Current.Get<Dictionary<string, object>>("RequestBodyProperties"); }
            set { ScenarioContext.Current.Set<Dictionary<string, object>>(value, "RequestBodyProperties"); }
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

        protected void GetResponse()
        {
            Action<HttpClient> setup = x =>
            {
                foreach (var header in RequestHeaders)
                {
                    x.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            };
            SendRequest(x => x.GetAsync(RequestUrl), setup).Wait();
        }

        protected void PutRequest()
        {
            var json = JsonConvert.SerializeObject(RequestBodyProperties);
            var content = new StringContent(json);
            content.Headers.Clear();
            foreach (var header in RequestHeaders)
            {
                content.Headers.Add(header.Key, header.Value);
            }
            SendRequest(x => x.PutAsync(RequestUrl, content)).Wait();
        }

        protected async Task SendRequest(Func<HttpClient, Task<HttpResponseMessage>> request, Action<HttpClient> setup =null)
        {
            ResponseMessage = null;
            ResponseBody = null;
            Response = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(FeatureContext.ApiBaseUrl);
                if (setup != null)
                {
                    setup(client);
                }
                ResponseMessage = await request(client);
                ResponseBody = await ResponseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(ResponseBody))
                {
                    Response = JsonConvert.DeserializeObject<dynamic>(ResponseBody);
                }
            }
        }
    }
}
