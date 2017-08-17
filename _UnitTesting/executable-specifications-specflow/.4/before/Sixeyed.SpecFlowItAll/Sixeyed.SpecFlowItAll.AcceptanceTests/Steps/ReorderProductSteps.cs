using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.SpecFlowItAll.AcceptanceTests.Stubs;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests
{
    [Binding]
    public class ReorderProductSteps : StepBase
    {
        private dynamic _orderRequest;

        [Given(@"the item is going to be reordered")]
        public void GivenTheItemIsGoingToBeReordered()
        {
            _orderRequest = null;
            FeatureContext.ButtonToClick = "reorderButton";
        }

        [Given(@"the supplier receives reorder requests by email")]
        [Given(@"the supplier receives reorder requests by Web service")]
        [Given(@"the supplier receives reorder requests by message queue")]
        public void ForInformationOnly()
        {
            //do nothing
        }

        [Then(@"the product is recorded as available")]
        public void ThenTheProductIsRecordedAsAvailable()
        {
            var isAvailable = ExecuteScalar<bool>("SELECT IsAvailable FROM Products WHERE Code = '{0}'", FeatureContext.ProductCode);
            Assert.IsTrue(isAvailable);
        }

        [Then(@"the product shows as available on the website product list")]
        public void ThenTheProductShowsAsAvailableOnTheWebsiteProductList()
        {
            DiscontinueProductSteps.ValidateStockOnWebsiteProductList(0, true);
        }

        [Then(@"the supplier is sent an order request by email")]
        public void ThenTheSupplierIsSentAnOrderRequestByEmail()
        {
            Assert.AreEqual(1, SmtpStub.EmailCount);
            _orderRequest = SmtpStub.LastOrderRequest;
            var expectedTo = ExecuteScalar<string>("select s.ReorderAddress from products p join suppliers s on p.SupplierId = s.SupplierId where p.Code = '{0}'", FeatureContext.ProductCode);
            Assert.AreEqual(expectedTo, (string)_orderRequest.ToAddress);
            Assert.AreEqual("buyer@attap.com", (string)_orderRequest.FromAddress);
        }

        [Then(@"the order request specifies the product to be ordered")]
        public void ThenTheOrderRequestSpecifiestheProductToBeOrdered()
        {
            Assert.IsTrue(((string)_orderRequest.ProductCode).EndsWith(FeatureContext.ProductCode));
        }
        
        [Then(@"the supplier is sent an order request by Web service")]
        public void ThenTheSupplierIsSentAnOrderRequestByWebService()
        {
            Assert.AreEqual(1, OrderServiceStub.CallCount);
            _orderRequest = OrderServiceStub.LastOrderRequest;
            Assert.AreEqual("ATTAP", (string)_orderRequest.FromAddress);
        }


        [Then(@"the supplier is sent an order request by message queue")]
        public void ThenTheSupplierIsSentAnOrderRequestByMessageQueue()
        {
            Assert.AreEqual(1, MessageHandlerStub.MessageCount);
            _orderRequest = MessageHandlerStub.LastOrderRequest;
            Assert.AreEqual("ATTAP", (string)_orderRequest.FromAddress);
        }
    }
}