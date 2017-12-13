using System;
using TechTalk.SpecFlow;
using BookShop.AcceptanceTests.Drivers.Home;

namespace BookShop.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        private readonly HomeDriver _homeDriver;

        public HomeSteps(HomeDriver driver)
        {
            _homeDriver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        [When(@"I go to shop")]
        public void WhenIGoToShop()
        {
            _homeDriver.Navigate();
        }

        [Then(@"the home screen should show the following books")]
        public void ThenTheHomeScreenShouldShowTheFollowingBooks(Table expectedBooks)
        {
            _homeDriver.ShowBooks(expectedBooks);
        }
    }
}
