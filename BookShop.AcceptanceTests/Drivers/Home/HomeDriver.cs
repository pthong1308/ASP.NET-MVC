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
