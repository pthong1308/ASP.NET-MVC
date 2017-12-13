using System;
using TechTalk.SpecFlow;
using BookShop.AcceptanceTests.Drivers.Catalog;

namespace BookShop.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class BookSteps
    {
        private readonly BookDriver _bookDriver;
        private readonly BookDetailsDriver _bookdetailsDriver;

        public BookSteps(BookDriver _bookdriver, BookDetailsDriver _bookdetailsdriver)
        {
            _bookDriver = _bookdriver;
            _bookdetailsDriver = _bookdetailsdriver;
        }

        [Given(@"the following books")]
        public void GivenTheFollowingBooks(Table givenBooks)
        {
            _bookdetailsDriver.InsertBookToDB(givenBooks);
        }

        [When(@"I open the details of '(.*)'")]
        public void WhenIOpenTheDetailsOf(string bookId)
        {
            _bookdetailsDriver.OpenBookDetails(bookId);
        }

        [Then(@"the book details should show")]
        public void ThenTheBookDetailsShouldShow(Table shownBookDetails)
        {
            _bookdetailsDriver.ShowBookDetails(shownBookDetails);
        }

        [Given(@"I am on Create Book Page")]
        public void GivenIAmOnCreateBookPage()
        {
            _bookDriver.Navigate("Create");
        }

        [When(@"I input the following information")]
        public void WhenIInputTheFollowingInformation(Table inputBook)
        {
            _bookDriver.CreateBook(inputBook);
        }

        [Then(@"the list of books should update")]
        public void ThenTheListOfBooksShouldUpdate(Table shownBooks)
        {
            _bookDriver.ShowBooks(shownBooks);
        }
    }
}
