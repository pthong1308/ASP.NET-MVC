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
    public partial class US03_ShoppingCartFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "US03_ShoppingCart.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US03 - Shopping cart", "\tAs a potential customer\r\n\tI want to collect books in a shopping cart\r\n\tSo that I" +
                    " can order several books at once.", ProgrammingLanguage.CSharp, new string[] {
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "US03 - Shopping cart")))
            {
                global::BookShop.AcceptanceTests.Features.US03_ShoppingCartFeature.FeatureSetup(null);
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
#line 7
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
                        "Gojko Adzic",
                        "Bridging the Communication Gap",
                        "24.75"});
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
#line 8
 testRunner.Given("the following books", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Books can be placed into shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void BooksCanBePlacedIntoShoppingCart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Books can be placed into shopping cart", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 23
 testRunner.Given("I have a shopping cart with: \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.When("I place \'Domain Driven Design\' into the shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("my shopping cart should contain 2 types of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("my shopping cart should contain 1 copy of \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("my shopping cart should contain 1 copy of \'Domain Driven Design\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Shopping cart should show total number of items and total price")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void ShoppingCartShouldShowTotalNumberOfItemsAndTotalPrice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shopping cart should show total number of items and total price", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 31
 testRunner.Given("I have a shopping cart with: \'Analysis Patterns\', \'Domain Driven Design\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.When("I place \'Analysis Patterns\' into the shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("my shopping cart should contain 2 types of items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.And("my shopping cart should contain 3 items in total", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("my shopping cart should show a total price of 146.74", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The shopping cart should be initially empty")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void TheShoppingCartShouldBeInitiallyEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The shopping cart should be initially empty", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 39
 testRunner.When("I go to shop", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("my shopping cart should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A type of book can be entirely removed from the shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void ATypeOfBookCanBeEntirelyRemovedFromTheShoppingCart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A type of book can be entirely removed from the shopping cart", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 44
 testRunner.Given("I have a shopping cart with: \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("I delete \'Analysis Patterns\' from the shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("my shopping cart should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding the same book to shopping cart again should increase quantity")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void AddingTheSameBookToShoppingCartAgainShouldIncreaseQuantity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding the same book to shopping cart again should increase quantity", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 50
 testRunner.Given("I have a shopping cart with: \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.When("I place \'Analysis Patterns\' into the shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("my shopping cart should contain 1 type of item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.And("my shopping cart should contain 2 copies of \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quantity of a book can be changed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void QuantityOfABookCanBeChanged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Quantity of a book can be changed", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 57
 testRunner.Given("I have a shopping cart with: \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.When("I change the quantity of \'Analysis Patterns\' to 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("my shopping cart should contain 1 type of item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.And("my shopping cart should contain 3 copies of \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing quantity of book to 0 should remove book from shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03 - Shopping cart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void ChangingQuantityOfBookTo0ShouldRemoveBookFromShoppingCart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changing quantity of book to 0 should remove book from shopping cart", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 64
 testRunner.Given("I have a shopping cart with: \'Analysis Patterns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.When("I change the quantity of \'Analysis Patterns\' to 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("my shopping cart should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
