using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            //TODO
        }

        [Then(@"the order request specifies the product to be ordered")]
        public void ThenTheOrderRequestSpecifiestheProductToBeOrdered()
        {
            //TODO
        }
    }
}