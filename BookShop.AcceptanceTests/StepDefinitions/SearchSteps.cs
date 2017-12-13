using BookShop.AcceptanceTests.Drivers.Search;
using TechTalk.SpecFlow;

namespace BookShop.AcceptanceTests.StepDefinitions
{
    //[Binding, Scope(Tag ="automated")]
    [Binding]
    public class SearchSteps
    {
        private readonly SearchDriver _searchDriver;

        public SearchSteps(SearchDriver driver)
        {
            _searchDriver = driver;
        }

        [When(@"I search for books by the phrase '(.*)'")]
        public void WhenISearchForBooksByThePhrase(string searchText)
        {
            _searchDriver.Search(searchText);
        }

        [Then(@"the list of found books should contain only: (.*)")]
        public void ThenTheListOfFoundBooksShouldContainOnly(string expectedTitleList)
        {
            _searchDriver.ShowBooks(expectedTitleList);
        }

        [Then(@"the list of found books should be:")]
        public void ThenTheListOfFoundBooksShouldBe(Table expectedBooks)
        {
            _searchDriver.ShowBooks(expectedBooks);
        }
    }
}
