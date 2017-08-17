using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests
{
    [Binding]
    public class DiscontinueProductSteps
    {
        private string _productCode;
        private bool _isDiscontinue;

        [Given(@"that we have no more stock of the product '(.*)'")]
        public void GivenThatWeHaveNoMoreStockOfTheProduct(string productCode)
        {
            _productCode = productCode;
        }

        [Given(@"the item is not to be re-ordered")]
        public void GivenTheItemIsNotToBeRe_Ordered()
        {
            _isDiscontinue = true;
        }

        [When(@"I discontinue the item in the management portal")]
        public void WhenIDiscontinueTheItemInTheManagementPortal()
        {
            var app = Application.Launch("WpfApplication\\Sixeyed.SpecFlowItAll.WpfApplication.exe");
            var window = app.GetWindow("MainWindow");
            window.WaitWhileBusy();
            var list = window.Get<ListView>("productDataGrid");
            window.WaitWhileBusy();
            foreach (var row in list.Rows)
            {
                var productCodeElement = row.GetElement(SearchCriteria.ByText(_productCode));
                if (productCodeElement == null)
                {
                    continue;
                }
                var discontinueElement = row.GetElement(SearchCriteria.ByAutomationId("discontinueButton"));
                var discontinueButton = new Button(discontinueElement, window.ActionListener);
                discontinueButton.Click();
            }
        }

        [Then(@"the product shows as not available on the website product list")]
        public void ThenTheProductShowsAsNotAvailableOnTheWebsiteProductList()
        {
            using (var driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://localhost/Sixeyed.SpecFlowItAll.MvcApplication/products");
                var stockCount = driver.FindElementById("stockCount_" + _productCode);
                Assert.AreEqual("0", stockCount.Text);
                var isAvailable = driver.FindElementById("isAvailable_" + _productCode).FindElements(By.TagName("input")).First();
                var checkedValue = isAvailable.GetAttribute("checked");
                Assert.AreNotEqual("true", checkedValue);
                driver.Quit();
            }
        }

        [Then(@"the product shows as discontinued on the website product page")]
        public void ThenTheProductShowsAsDiscontinuedOnTheWebsiteProductPage()
        {
            using (var driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://localhost/Sixeyed.SpecFlowItAll.MvcApplication/products/Details/" + _productCode);
                var availability = driver.FindElementById("availability");
                Assert.AreEqual("Sorry! This product is no longer available.", availability.Text);

            }
        }

        [Then(@"the product is recorded as not available")]
        public void ThenTheProductIsRecordedAsNotAvailable()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopContext"].ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT IsAvailable FROM Products WHERE Code = '" + _productCode + "'";
                    var actual = (bool)command.ExecuteScalar();
                    Assert.IsFalse(actual);
                }
            }
        }

        [Then(@"the stock count for the product is recorded as (.*)")]
        public void ThenTheStockCountForTheProductIsRecordedAs(int expectedCount)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopContext"].ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT StockCount FROM Products WHERE Code = '" + _productCode + "'";
                    var actual = (int)command.ExecuteScalar();
                    Assert.AreEqual(expectedCount, actual);
                }
            }
        }

[BeforeScenario("resetDatabase")]
[AfterScenario("resetDatabase")]
public void ResetDatabase()
{
    Process.Start("sqlcmd", @"-S SC-2013-DEV\SQL2012DEV -d Sixeyed.SpecFlowItAll.Database -i 02.INSERT-Products.sql");
}
    }
}
