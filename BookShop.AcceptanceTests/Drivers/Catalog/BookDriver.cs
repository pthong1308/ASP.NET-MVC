using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BookShop.Controllers;
using BookShop.Models;
using BookShop.AcceptanceTests.Support;
using BookShop.AcceptanceTests.Common;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BookShop.AcceptanceTests.Drivers.Catalog
{
    public class BookDriver
    {
        private ActionResult _result;
        private CatalogController _controller = new CatalogController();

        public void Navigate(string relativeURL, int? bookId = null)
        {
            switch (relativeURL)
            {
                case "Create":
                    _result = _controller.Create();
                    break;
                case "Edit":
                    _result = _controller.Edit(bookId);
                    break;
            }
        }

        public void CreateBook(Table inputBook)
        {
            var row = inputBook.Rows[0];

            var book = new Book
            {
                Author = row["Author"],
                Title = row["Title"],
                Price = Convert.ToDecimal(row["Price"])
            };

            _result = _controller.Create(book);
        }

        public void ShowBooks(Table shownBooks)
        {
            //Arrange
            var expectedBooks = shownBooks.CreateSet<Book>();

            //Act
            ActionResult result = _controller.Index();
            var actualBooks = result.Model<IEnumerable<Book>>();

            //Assert
            BookAssertions.BookListScreenShouldShowInOrder(actualBooks, expectedBooks);
        }
    }
}
