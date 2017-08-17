using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Steps.Api
{
    [Binding]
    public class GetProductSteps : ApiStepBase
    {
        private HttpClient _loaderClient;
        private DateTime _stopAt;

        [Given(@"a request for the product with code '(.*)'")]
        public void GivenARequestForTheProductWithCode(string productCode)
        {
            FeatureContext.ProductCode = productCode;
            RequestUrl = string.Format("products/{0}", productCode);
        }

        [Given(@"the request contains the header values")]
        public void GivenTheRequestContainsTheHeaderValues(Table table)
        {
            RequestHeaders = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                RequestHeaders.Add(row["Name"], row["Value"]);
            }
        }

        [When(@"the client makes a get request")]
        public void WhenTheClientMakesAGetRequest()
        {
            GetResponse();
        }

        [Then(@"the API returns with response code '(.*)'")]
        public void ThenTheAPIReturnsWithResponseCode(int expectedStatusCode)
        {
            Assert.AreEqual(expectedStatusCode, (int)ResponseMessage.StatusCode);
        }

        [Then(@"the response contains the header values")]
        public void ThenTheResponseContainsTheHeaderValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                var expectedHeader = row["Name"];
                var expectedValue = row["Value"];
                Assert.AreEqual(expectedValue, ResponseMessage.Headers.GetValues(expectedHeader).First());
            }
        }

        [Then(@"the response contains product details")]
        public void ThenTheResponseContainsProductDetails()
        {
            Assert.IsFalse(string.IsNullOrEmpty(ResponseBody));
        }

        [Then(@"the product has the values")]
        public void ThenTheProductHasTheValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                var propertyName = row["Name"];
                var expectedValue = row["Value"];
                Assert.AreEqual(expectedValue, Response.Value<string>(propertyName));
            }
        }

        [Then(@"the response does not contain product details")]
        public void ThenTheResponseDoesNotContainProductDetails()
        {
            Assert.IsTrue(string.IsNullOrEmpty(ResponseBody));
        }

        [Given(@"the API is under heavy load at (.*) requests per second")]
        public void GivenTheAPIIsUnderHeavyLoadAtRequestsPerSecond(int p0)
        {
            var loaderUrl = ConfigurationManager.AppSettings["loader.url"];
            var loaderKey = ConfigurationManager.AppSettings["loader.key"];
            _loaderClient = new HttpClient();
            _loaderClient.DefaultRequestHeaders.Add("loaderio-auth", loaderKey);
            var content = new StringContent("");
            _loaderClient.PutAsync(loaderUrl, content);
        }

        [When(@"the client makes repeated get requests for (.*) seconds")]
        public void WhenTheClientMakesRepeatedGetRequestsForSeconds(int durationSeconds)
        {
            _stopAt = DateTime.Now.AddSeconds(durationSeconds);
        }

        [Then(@"the API returns a positive response within (.*) milliseconds for each request")]
        public void ThenTheAPIReturnsAPositiveResponseWithinMillisecondsForEachRequest(int timeoutMilliseconds)
        {
            var callNumber = 1;
            while (DateTime.Now.Ticks < _stopAt.Ticks)
            {
                var stopwatch = Stopwatch.StartNew();
                GetResponse();
                ThenTheAPIReturnsWithResponseCode(200);
                ThenTheResponseContainsProductDetails();
                Debug.WriteLine("Call number: {0} took: {1}ms", callNumber++, stopwatch.ElapsedMilliseconds);
                Assert.IsTrue(stopwatch.ElapsedMilliseconds < timeoutMilliseconds);
            }
        }

        [BeforeScenario("performance")]
        public void PointToPerformance()
        {
            FeatureContext.ApiBaseUrl = ConfigurationManager.AppSettings["api.url.perf"];
        }

        [AfterScenario("performance")]
        public void PointToLocal()
        {
            FeatureContext.ApiBaseUrl = ConfigurationManager.AppSettings["api.url"];
        }
    }
}
