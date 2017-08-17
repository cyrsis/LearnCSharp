﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.33440
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Features.Api
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class PutProductFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PutProduct.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Put Product", "In order to see product details and stock levels\nAs an API consumer\nI want to get" +
                    " a product by its code", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Put Product")))
            {
                Sixeyed.SpecFlowItAll.AcceptanceTests.Features.Api.PutProductFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Discontinue Product - green path")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Put Product")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("resetDatabase")]
        public virtual void DiscontinueProduct_GreenPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Discontinue Product - green path", new string[] {
                        "resetDatabase"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("a request for the product with code \'fish-heads\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "Content-Type",
                        "application/json"});
            table1.AddRow(new string[] {
                        "x-api-key",
                        "BBDE1E2C"});
#line 9
 testRunner.And("the request contains the header values", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value",
                        "As"});
            table2.AddRow(new string[] {
                        "stockCount",
                        "0",
                        "System.Int32"});
            table2.AddRow(new string[] {
                        "isAvailable",
                        "false",
                        "System.Boolean"});
#line 13
 testRunner.And("the request contains the values", ((string)(null)), table2, "And ");
#line 17
 testRunner.When("the client makes a put request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the product is recorded as not available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("the stock count for the product is recorded as 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("the API returns with response code \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "x-api-version",
                        "1.0"});
#line 21
 testRunner.And("the response contains the header values", ((string)(null)), table3, "And ");
#line 24
 testRunner.And("the response does not contain product details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Discontinue Product - unauthorized")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Put Product")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("resetDatabase")]
        public virtual void DiscontinueProduct_Unauthorized()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Discontinue Product - unauthorized", new string[] {
                        "resetDatabase"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("a request for the product with code \'fish-heads\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "Content-Type",
                        "application/json"});
            table4.AddRow(new string[] {
                        "x-api-key",
                        "NOTAVALIDKEY"});
#line 29
 testRunner.And("the request contains the header values", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value",
                        "As"});
            table5.AddRow(new string[] {
                        "stockCount",
                        "0",
                        "System.Int32"});
            table5.AddRow(new string[] {
                        "isAvailable",
                        "false",
                        "System.Boolean"});
#line 33
 testRunner.And("the request contains the values", ((string)(null)), table5, "And ");
#line 37
 testRunner.When("the client makes a put request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("the API returns with response code \'401\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table6.AddRow(new string[] {
                        "x-api-version",
                        "1.0"});
#line 39
 testRunner.And("the response contains the header values", ((string)(null)), table6, "And ");
#line 42
 testRunner.And("the stock count for the product is recorded as 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("the response does not contain product details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reorder Product - green path")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Put Product")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("resetDatabase")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("wcfStub")]
        public virtual void ReorderProduct_GreenPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reorder Product - green path", new string[] {
                        "resetDatabase",
                        "wcfStub"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("a request for the product with code \'chocolate-sprinkles\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table7.AddRow(new string[] {
                        "Content-Type",
                        "application/json"});
            table7.AddRow(new string[] {
                        "x-api-key",
                        "BBDE1E2C"});
#line 49
 testRunner.And("the request contains the header values", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value",
                        "As"});
            table8.AddRow(new string[] {
                        "stockCount",
                        "0",
                        "System.Int32"});
            table8.AddRow(new string[] {
                        "isAvailable",
                        "true",
                        "System.Boolean"});
#line 53
 testRunner.And("the request contains the values", ((string)(null)), table8, "And ");
#line 57
 testRunner.When("the client makes a put request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("the supplier is sent an order request by Web service within 600 milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.And("the order request specifies the product to be ordered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("the product is recorded as available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("the stock count for the product is recorded as 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("the API returns with response code \'202\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table9.AddRow(new string[] {
                        "x-api-version",
                        "1.0"});
#line 63
 testRunner.And("the response contains the header values", ((string)(null)), table9, "And ");
#line 66
 testRunner.And("the response does not contain product details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
