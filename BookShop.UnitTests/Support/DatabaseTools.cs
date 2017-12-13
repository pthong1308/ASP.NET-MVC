using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookShop.Models;

namespace BookShop.UnitTests.Support
{
    [TestClass]
    public static class DatabaseTools
    {
        [AssemblyInitialize]
        public static void CleanDatabase(TestContext context)
        {
            using (var db = new DatabaseContext())
            {
                db.OrderLines.RemoveRange(db.OrderLines);
                db.Orders.RemoveRange(db.Orders);
                db.Books.RemoveRange(db.Books);
                db.SaveChanges();
            }
        }
    }
}
