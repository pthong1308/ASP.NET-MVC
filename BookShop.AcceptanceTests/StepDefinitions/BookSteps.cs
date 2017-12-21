using System;
using TechTalk.SpecFlow;
using BookShop.AcceptanceTests.Drivers.Catalog;

namespace BookShop.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class BookSteps
    {
        private readonly BookDriver _bookDriver;

        public BookSteps(BookDriver _bookdriver)
        {
            _bookDriver = _bookdriver;
        }

        [Given(@"the following books")]
        public void GivenTheFollowingBooks(Table givenBooks)
        {
            _bookDriver.InsertBookToDB(givenBooks);
        }

        [When(@"I open the details of '(.*)'")]
        public void WhenIOpenTheDetailsOf(string bookId)
        {
            //Save selected book title into ScenarioContext object so that we can get it in the next step
            ScenarioContext.Current.Add("bookId", bookId);

            _bookDriver.OpenBookDetails(bookId);
        }

        [Then(@"the book details should show")]
        public void ThenTheBookDetailsShouldShow(Table shownBookDetails)
        {
            _bookDriver.ShowBookDetails(shownBookDetails);
        }

        [Given(@"I am on Create Book Page")]
        public void GivenIAmOnCreateBookPage()
        {
            _bookDriver.NavigateCreateBook();
        }

        [When(@"I input the following information")]
        public void WhenIInputTheFollowingInformation(Table inputBook)
        {
            _bookDriver.CreateBook(inputBook);
        }

        [When(@"I upload images for this book: '(.*)'")]
        public void WhenIUploadImagesForThisBook(string uploadFiles)
        {
            _bookDriver.UploadImage(uploadFiles);
        }

        [When(@"I update the price to (.*)")]
        public void WhenIUpdateThePriceTo(Decimal price)
        {
            _bookDriver.UpdateBook(price);
        }

        [Then(@"the list of books should update")]
        public void ThenTheListOfBooksShouldUpdate(Table shownBooks)
        {
            _bookDriver.ShowBooks(shownBooks);
        }

        [Then(@"The images should upload on server")]
        public void ThenTheImagesShouldUploadOnServer()
        {
            _bookDriver.SaveImages();
        }
    }
}
