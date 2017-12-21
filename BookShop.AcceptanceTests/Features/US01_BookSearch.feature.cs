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
    public partial class US01_BookSearchFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "US01_BookSearch.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US01 - Book Search", "\tAs a potential customer\r\n\tI want to search for books by a simple phrase\r\n\tSo tha" +
                    "t I can easily allocate books by something I remember from them.", ProgrammingLanguage.CSharp, new string[] {
                        "automated"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "US01 - Book Search")))
            {
                global::BookShop.AcceptanceTests.Features.US01_BookSearchFeature.FeatureSetup(null);
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
#line 10
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Author",
                        "Title"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Specification By Example"});
            table1.AddRow(new string[] {
                        "Eckhart Tolle",
                        "The Power of Now"});
            table1.AddRow(new string[] {
                        "Jeff Sutherland",
                        "Scrum: The Art of Doing Twice the Work in Half the Time"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Bridging the Communication Gap"});
            table1.AddRow(new string[] {
                        "Mitch Lacey",
                        "The Scrum Field Guide"});
            table1.AddRow(new string[] {
                        "Ted Pattison",
                        "Inside Windows SharePoint Services"});
#line 11
 testRunner.Given("the following books", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Title should be matched")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US01 - Book Search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void TitleShouldBeMatched()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Title should be matched", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 22
 testRunner.When("I search for books by the phrase \'Power\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("the list of found books should contain only: \'The Power of Now\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Author should be matched")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US01 - Book Search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void AuthorShouldBeMatched()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Author should be matched", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 26
 testRunner.When("I search for books by the phrase \'Gojko\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("the list of found books should contain only: \'Specification By Example\', \'Bridgin" +
                    "g the Communication Gap\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Space should be treated as multiple OR search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US01 - Book Search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void SpaceShouldBeTreatedAsMultipleORSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Space should be treated as multiple OR search", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 30
 testRunner.When("I search for books by the phrase \'Windows Communication\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("the list of found books should contain only: \'Bridging the Communication Gap\', \'I" +
                    "nside Windows SharePoint Services\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Search result should be ordered by book title")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US01 - Book Search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void SearchResultShouldBeOrderedByBookTitle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search result should be ordered by book title", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 34
 testRunner.When("I search for books by the phrase \'id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title"});
            table2.AddRow(new string[] {
                        "Bridging the Communication Gap"});
            table2.AddRow(new string[] {
                        "Inside Windows SharePoint Services"});
            table2.AddRow(new string[] {
                        "The Scrum Field Guide"});
#line 35
 testRunner.Then("the list of found books should be:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SimpleSearchScenarioOutlineSyntax(string searchPhrase, string books, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "alternative_syntax"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simple search (scenario outline syntax)", @__tags);
#line 42
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 43
 testRunner.When(string.Format("I search for books by the phrase \'{0}\'", searchPhrase), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then(string.Format("the list of found books should contain only: {0}", books), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simple search (scenario outline syntax): Power")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US01 - Book Search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("alternative_syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Power")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:search phrase", "Power")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:books", "\'The Power of Now\'")]
        public virtual void SimpleSearchScenarioOutlineSyntax_Power()
        {
#line 42
this.SimpleSearchScenarioOutlineSyntax("Power", "\'The Power of Now\'", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simple search (scenario outline syntax): Windows Communication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US01 - Book Search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("alternative_syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Windows Communication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:search phrase", "Windows Communication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:books", "\'Bridging the Communication Gap\', \'Inside Windows SharePoint Services\'")]
        public virtual void SimpleSearchScenarioOutlineSyntax_WindowsCommunication()
        {
#line 42
this.SimpleSearchScenarioOutlineSyntax("Windows Communication", "\'Bridging the Communication Gap\', \'Inside Windows SharePoint Services\'", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
