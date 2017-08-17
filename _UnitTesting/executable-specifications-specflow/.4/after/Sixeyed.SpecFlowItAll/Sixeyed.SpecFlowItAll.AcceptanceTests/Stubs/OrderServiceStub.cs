using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Stubs
{
    [Binding]
    [ServiceContract]
    public class OrderServiceStub
    {
        public static int CallCount { get; private set; }

        public static dynamic LastOrderRequest { get; private set; }

        private ServiceHost _host;

        [OperationContract(Action = "http://tempuri.org/OrderService/Place", ReplyAction = "http://tempuri.org/OrderService/PlaceResponse")]
        public void Place(string customerId, string productCode)
        {
            Thread.Sleep(500);

            CallCount++;

            LastOrderRequest = new
            {
                FromAddress = customerId,
                ProductCode = productCode
            };
        }

        [BeforeScenario("wcfStub")]
        public void Start()
        {
            var serviceType = typeof(OrderServiceStub);
            const string address = "net.pipe://localhost/Sixeyed.SpecFlowItAll.Stubs.WcfService/";
            _host = new ServiceHost(serviceType, new Uri(address));
            var binding = new NetNamedPipeBinding();
            _host.AddServiceEndpoint(serviceType, binding, "OrderService.svc");
            _host.Open();
        }

        [AfterScenario("wcfStub")]
        public void Stop()
        {
            _host.Close();
        }
    }
}
