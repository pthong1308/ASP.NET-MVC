using System.Collections.Generic;
using System.Linq;
using BookShop.Models;
using FluentAssertions;

namespace BookShop.AcceptanceTests.Common
{
    public class BookAssertions
    {
        public static void FoundBooksShouldMatchTitles(IEnumerable<Book> foundBooks, IEnumerable<string> expectedTitles)
        {
            foundBooks.Select(b => b.Title).Should().BeEquivalentTo(expectedTitles);
        }

        public static void FoundBooksShouldMatchTitlesInOrder(IEnumerable<Book> foundBooks, IEnumerable<string> expectedTitles)
        {
            foundBooks.Select(b => b.Title).Should().Equal(expectedTitles);
        }

        public static void HomeScreenShouldShow(IEnumerable<Book> shownBooks, string expectedTitle)
        {
            shownBooks.Select(b => b.Title).Should().Contain(expectedTitle);
        }

        public static void HomeScreenShouldShow(IEnumerable<Book> shownBooks, IEnumerable<string> expectedTitles)
        {
            shownBooks.Select(b => b.Title).Should().BeEquivalentTo(expectedTitles);
        }

        public static void HomeScreenShouldShowInOrder(IEnumerable<Book> shownBooks, IEnumerable<string> expectedTitles)
        {
            shownBooks.Select(b => b.Title).Should().Equal(expectedTitles);
        }

        public static void BookListScreenShouldShowInOrder(IEnumerable<Book> shownBooks, IEnumerable<Book> expectedBooks)
        {
            shownBooks.ShouldAllBeEquivalentTo(expectedBooks, option => option.Excluding(o => o.Id).WithStrictOrdering());
        }
    }
}
