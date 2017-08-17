using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Steps.Api
{
    [Binding]
    public class PutProductSteps : ApiStepBase
    {
        [Given(@"the request contains the values")]
        public void GivenTheRequestContainsTheValues(Table table)
        {
            RequestBodyProperties = new Dictionary<string, object>();
            foreach (var row in table.Rows)
            {
                var name = row["Name"];
                var rawValue = row["Value"];
                var asType = row["As"];
                var type = Type.GetType(asType);
                object actualValue = Convert.ChangeType(rawValue, type);
                RequestBodyProperties.Add(name, actualValue);
            }
        }

        [When(@"the client makes a put request")]
        public void WhenTheClientMakesAPutRequest()
        {
            PutRequest();
        }

    }
}
