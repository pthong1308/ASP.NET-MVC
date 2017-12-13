using System.Linq;
using TechTalk.SpecFlow;
using BookShop.AcceptanceTests.Common;
using BookShop.UITests.Selenium.Support;
using BookShop.Models;
using OpenQA.Selenium;

namespace BookShop.UITests.Selenium
{
    [Binding, Scope(Tag ="web")]
    public class SearchSteps : SeleniumStepsBase
    {
        [When(@"I search for books by the phrase '(.*)'")]
        public void WhenISearchForBooksByThePhrase(string searchText)
        {
            //Navigate to home page
            Browser.NavigateTo("Home");

            //Input value to search for
            Browser.SetTextBoxValue("searchTerm", searchText);

            //Click on search button
            Browser.SubmitForm("searchForm");
        }

        [Then(@"the list of found books should contain only: '(.*)'")]
        public void ThenTheListOfFoundBooksShouldContainOnly(string expectedTitleList)
        {
            //Arrange
            var expectedTitles = expectedTitleList.Split(',').Select(t => t.Trim().Trim('\''));

            //Action
            Browser.SwitchTo().DefaultContent();
            var foundBooks = from row in Browser.FindElements(By.XPath("//table/tbody/tr"))
                             let title = row.FindElement(By.Id("title")).Text
                             let author = row.FindElement(By.Id("author")).Text
                             select new Book { Title = title, Author = author };

            //Assert
            BookAssertions.FoundBooksShouldMatchTitles(foundBooks, expectedTitles);
        }

        [Then(@"the list of found books should be:")]
        public void ThenTheListOfFoundBooksShouldBe(Table expectedBooks)
        {
            //Arrange
            var expectedTitles = expectedBooks.Rows.Select(r => r["Title"]);

            //Action
            var foundBooks = from row in Browser.FindElements(By.XPath("//table/tbody/tr"))
                             let title = row.FindElement(By.Id("title")).Text
                             let author = row.FindElement(By.Id("author")).Text
                             select new Book { Title = title, Author = author };
            
            //Assert
            BookAssertions.FoundBooksShouldMatchTitlesInOrder(foundBooks, expectedTitles);
        }
    }
}
