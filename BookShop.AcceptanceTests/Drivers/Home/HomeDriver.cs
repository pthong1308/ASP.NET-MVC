using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using BookShop.AcceptanceTests.Support;
using BookShop.AcceptanceTests.Common;
using BookShop.Controllers;
using BookShop.Models;
using TechTalk.SpecFlow;

namespace BookShop.AcceptanceTests.Drivers.Home
{
    public class HomeDriver
    {
        private ActionResult _result;

        public void Navigate()
        {
            using (var controller = new HomeController())
            {
                _result = controller.Index();
            }
        }

        public void ShowBook(string expectedTitle)
        {
            var shownBooks = _result.Model<IEnumerable<Book>>();
            BookAssertions.HomeScreenShouldShow(shownBooks, expectedTitle);
        }

        public void ShowBooks(string expectedTitles)
        => ShowBooks(from t in expectedTitles.Split(',')
                      select t.Trim().Trim('\''));
        

        public void ShowBooks(Table expectedBooks)
        => ShowBooks(expectedBooks.Rows.Select(r => r["Title"]));

        public void ShowBooks(IEnumerable<string> expectedTitles)
        {
            //Act
            var shownBooks = _result.Model<IEnumerable<Book>>();

            //Assert
            BookAssertions.HomeScreenShouldShow(shownBooks, expectedTitles);
        }
    }
}
