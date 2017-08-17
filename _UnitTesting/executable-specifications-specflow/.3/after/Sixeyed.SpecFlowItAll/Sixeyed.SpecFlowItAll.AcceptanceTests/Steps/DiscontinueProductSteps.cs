using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using System.Linq;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests
{
    [Binding]
    public class DiscontinueProductSteps : StepBase
    {

        [Given(@"that we have no more stock of the product '(.*)'")]
        public void GivenThatWeHaveNoMoreStockOfTheProduct(string productCode)
        {
            FeatureContext.ProductCode = productCode;
        }

        [Given(@"the item is not to be re-ordered")]
        public void GivenTheItemIsNotToBeRe_Ordered()
        {
            FeatureContext.ButtonToClick = "discontinueButton";
        }

        [When(@"I discontinue the item in the management portal")]
        public void WhenIDiscontinueTheItemInTheManagementPortal()
        {
            var app = FeatureContext.WpfApplication;
            var window = app.GetWindow("MainWindow");
            window.WaitWhileBusy();
            var list = window.Get<ListView>("productDataGrid");
            window.WaitWhileBusy();
            foreach (var row in list.Rows)
            {
                var productCodeElement = row.GetElement(SearchCriteria.ByText(FeatureContext.ProductCode));
                if (productCodeElement == null)
                {
                    continue;
                }
                var buttonElement = row.GetElement(SearchCriteria.ByAutomationId(FeatureContext.ButtonToClick));
                var button = new Button(buttonElement, window.ActionListener);
                button.Click();
            }
        }

        [Then(@"the product shows as not available on the website product list")]
        public void ThenTheProductShowsAsNotAvailableOnTheWebsiteProductList()
        {
            ValidateStockOnWebsiteProductList(0, false);
        }

        public static void ValidateStockOnWebsiteProductList(int expectedStockCount, bool expectedIsAvailable)
        {
            var driver = FeatureContext.WebDriver;
            driver.Navigate().GoToUrl("http://localhost/Sixeyed.SpecFlowItAll.MvcApplication/products");
            var stockCount = driver.FindElementById("stockCount_" + FeatureContext.ProductCode);
            Assert.AreEqual(expectedStockCount.ToString(), stockCount.Text);
            var isAvailable = driver.FindElementById("isAvailable_" + FeatureContext.ProductCode).FindElements(By.TagName("input")).First();
            var checkedValue = isAvailable.GetAttribute("checked");
            if (expectedIsAvailable)
            {
                Assert.AreEqual("true", checkedValue);
            }
            else
            {
                Assert.IsNull(checkedValue);
            }
        }

        [Then(@"the availability for the product on the website product page shows the message")]
        public void ThenTheAvailabilityForTheProductOnTheWebsiteProductPageShowsTheMessage(Table table)
        {
            var expectedMessage = table.Rows.First()["message"];
            var driver = FeatureContext.WebDriver;
            driver.Navigate().GoToUrl("http://localhost/Sixeyed.SpecFlowItAll.MvcApplication/products/Details/" + FeatureContext.ProductCode);
            var availability = driver.FindElementById("availability");
            Assert.AreEqual(expectedMessage, availability.Text);
        }


        [Then(@"the product is recorded as not available")]
        public void ThenTheProductIsRecordedAsNotAvailable()
        {
            var isAvailable = ExecuteScalar<bool>("SELECT IsAvailable FROM Products WHERE Code = '{0}'", FeatureContext.ProductCode);
            Assert.IsFalse(isAvailable);
        }

        [Then(@"the stock count for the product is recorded as (.*)")]
        public void ThenTheStockCountForTheProductIsRecordedAs(int expectedCount)
        {
            var stockCount = ExecuteScalar<int>("SELECT StockCount FROM Products WHERE Code = '{0}'", FeatureContext.ProductCode);
            Assert.AreEqual(expectedCount, stockCount);
        }

        [BeforeScenario("resetDatabase")]
        //[AfterScenario("resetDatabase")]
        public void ResetDatabase()
        {
            var p = Process.Start("sqlcmd", @"-S SC-2013-DEV\SQL2012DEV -d Sixeyed.SpecFlowItAll.Database -i 02.INSERT-Products.sql");
            p.WaitForExit();
        }
    }
}
