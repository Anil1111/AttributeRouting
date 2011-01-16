// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Defining Routes Via Conventions")]
    public partial class DefiningRoutesViaConventionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Conventions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Defining Routes Via Conventions", "", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I generate the routes defined in the subject controllers");
#line hidden
        }
        
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention(string action, string method, string url)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the RestfulRouteConvention", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When(string.Format("I fetch the routes for the RestfulRouteConventionTest controller\'s {0} action", action));
#line 8
 testRunner.Then(string.Format("the route url is \"{0}\"", url));
#line 9
  testRunner.And("the default for \"controller\" is \"RestfulRouteConventionTest\"");
#line 10
  testRunner.And(string.Format("the default for \"action\" is \"{0}\"", action));
#line 11
  testRunner.And(string.Format("the route for {0} is constrained to {1} requests", action, method));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Index()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Index", "GET", "");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_New()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("New", "GET", "New");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Create()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Create", "POST", "");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Show()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Show", "GET", "{id}");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Edit()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Edit", "GET", "{id}/Edit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Update()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Update", "PUT", "{id}");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Delete()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Delete", "GET", "{id}/Delete");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Destroy()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Destroy", "DELETE", "{id}");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention_Custom()
        {
            this.GeneratingRoutesUsingTheRestfulRouteConvention("Custom", "GET", "Custom");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention on actions with an explicit ro" +
            "ute defined")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConventionOnActionsWithAnExplicitRouteDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the RestfulRouteConvention on actions with an explicit ro" +
                    "ute defined", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.When("I fetch the routes for the RestfulRouteConventionTest controller\'s Index action");
#line 27
 testRunner.Then("the 1st route url is \"\"");
#line 28
  testRunner.And("the 2nd route url is \"Legacy\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
