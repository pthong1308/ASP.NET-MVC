﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookShop.Controllers;
using BookShop.Models;
using BookShop.AcceptanceTests.Support;
using BookShop.AcceptanceTests.Common;
using TechTalk.SpecFlow;

namespace BookShop.AcceptanceTests.Drivers.Search
{
    public class SearchDriver
    {
        /*       private ActionResult _result;

               public SearchDriver(ActionResult result)
               {
                   _result = result;
               }
        */
        private readonly SearchResultState _state;

        public SearchDriver(SearchResultState state)
        {
            _state = state;
        }

        public void Search(string searchTerm)
        {
            var controller = new CatalogController();
            _state.ActionResult = controller.Search(searchTerm);
        }

        public void ShowBooks(string expectedTitlesString)
        {
            //Arrange
            var expectedTitles = from t in expectedTitlesString.Split(',')
                                    select t.Trim().Trim('\'');

            //Action
            var ShownBooks = _state.ActionResult.Model<IEnumerable<Book>>();

            //Assert
            BookAssertions.HomeScreenShouldShow(ShownBooks, expectedTitles);
        }

        public void ShowBooks(Table expectedBooks)
        {
            //Arrange
            var expectedTitles = expectedBooks.Rows.Select(r => r["Title"]);

            //Action
            var ShownBooks = _state.ActionResult.Model<IEnumerable<Book>>();

            //Assert
            BookAssertions.HomeScreenShouldShowInOrder(ShownBooks, expectedTitles);
        }
    }
}
