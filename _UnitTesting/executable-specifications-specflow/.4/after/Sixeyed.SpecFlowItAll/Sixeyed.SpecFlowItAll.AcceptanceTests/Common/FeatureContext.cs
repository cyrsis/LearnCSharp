using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;
using TestStack.White;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests
{
    [TestClass]
    public sealed class FeatureContext
    {
        public static Application WpfApplication { get; private set; }

        public static RemoteWebDriver WebDriver { get; private set; }

        public static string ProductCode
        {
            get { return ScenarioContext.Current.Get<string>("_productCode"); }
            set { ScenarioContext.Current["_productCode"] = value; }
        }

        public static string ButtonToClick
        {
            get { return ScenarioContext.Current.Get<string>("_buttonToClick"); }
            set { ScenarioContext.Current["_buttonToClick"] = value; }
        }

        public static string ApiBaseUrl
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("_apiBaseUrl"))
                {
                    ScenarioContext.Current["_apiBaseUrl"] = ConfigurationManager.AppSettings["api.url"];
                }
                return ScenarioContext.Current.Get<string>("_apiBaseUrl");
            }
            set { ScenarioContext.Current["_apiBaseUrl"] = value; }
        }

        //[AssemblyInitialize]
        public static void Start(TestContext context)
        {
            WpfApplication = Application.Launch("WpfApplication\\Sixeyed.SpecFlowItAll.WpfApplication.exe");
            WebDriver = new FirefoxDriver();
        }

        //[AssemblyCleanup]
        public static void Stop()
        {
            WpfApplication.Close();
            WpfApplication.Dispose();
            WebDriver.Close();
            WebDriver.Dispose();
        }
    }
}
