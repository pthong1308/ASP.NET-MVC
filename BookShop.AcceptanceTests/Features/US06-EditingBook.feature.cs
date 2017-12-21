﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BookShop.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class US06_EditingBookFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "US06-EditingBook.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US06 - Editing Book", "\tAs a sale role\r\n\tI want to edit information of an existing book item\r\n\tSo that t" +
                    "he potential customers have more products to choose", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "US06 - Editing Book")))
            {
                global::BookShop.AcceptanceTests.Features.US06_EditingBookFeature.FeatureSetup(null);
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
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Author",
                        "Title",
                        "Price"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Specification By Example",
                        "12.20"});
            table1.AddRow(new string[] {
                        "Eckhart Tolle",
                        "The Power of Now",
                        "12.58"});
            table1.AddRow(new string[] {
                        "Jeff Sutherland",
                        "Scrum: The Art of Doing Twice the Work in Half the Time",
                        "16.73"});
            table1.AddRow(new string[] {
                        "Mitch Lacey",
                        "The Scrum Field Guide",
                        "15.31"});
            table1.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns",
                        "50.20"});
            table1.AddRow(new string[] {
                        "Eric Evans",
                        "Domain Driven Design",
                        "46.34"});
            table1.AddRow(new string[] {
                        "Ted Pattison",
                        "Inside Windows SharePoint Services",
                        "31.49"});
            table1.AddRow(new string[] {
                        "Lisa Crispin and Janet Gregory",
                        "Agile Testing",
                        "20.20"});
            table1.AddRow(new string[] {
                        "Esther Derby and Diana Larsen",
                        "Agile Retrospectives",
                        "16.99"});
#line 7
 testRunner.Given("the following books", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successful Update Price and Image of Existing Book Item")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US06 - Editing Book")]
        public virtual void SuccessfulUpdatePriceAndImageOfExistingBookItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful Update Price and Image of Existing Book Item", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 20
 testRunner.When("I open the details of \'The Scrum Field Guide\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("I update the price to 17.31", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I upload images for this book: \'Scrum-MitchLacey.jpg\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Author",
                        "Title",
                        "Price"});
            table2.AddRow(new string[] {
                        "Gojko Adzic",
                        "Specification By Example",
                        "12.20"});
            table2.AddRow(new string[] {
                        "Eckhart Tolle",
                        "The Power of Now",
                        "12.58"});
            table2.AddRow(new string[] {
                        "Jeff Sutherland",
                        "Scrum: The Art of Doing Twice the Work in Half the Time",
                        "16.73"});
            table2.AddRow(new string[] {
                        "Esther Derby and Diana Larsen",
                        "Agile Retrospectives",
                        "16.99"});
            table2.AddRow(new string[] {
                        "Mitch Lacey",
                        "The Scrum Field Guide",
                        "17.31"});
            table2.AddRow(new string[] {
                        "Lisa Crispin and Janet Gregory",
                        "Agile Testing",
                        "20.20"});
            table2.AddRow(new string[] {
                        "Ted Pattison",
                        "Inside Windows SharePoint Services",
                        "31.49"});
            table2.AddRow(new string[] {
                        "Eric Evans",
                        "Domain Driven Design",
                        "46.34"});
            table2.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns",
                        "50.20"});
#line 23
 testRunner.Then("the list of books should update", ((string)(null)), table2, "Then ");
#line 34
 testRunner.And("The images should upload on server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
