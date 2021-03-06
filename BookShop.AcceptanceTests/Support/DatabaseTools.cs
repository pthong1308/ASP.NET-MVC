﻿using BookShop.Models;
using TechTalk.SpecFlow;

namespace BookShop.AcceptanceTests.Support
{
    [Binding]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            using (var db = new DatabaseContext())
            {
                db.OrderLines.RemoveRange(db.OrderLines);
                db.Orders.RemoveRange(db.Orders);
                db.UploadFiles.RemoveRange(db.UploadFiles);
                db.Books.RemoveRange(db.Books);
                db.SaveChanges();
            }
        }
    }
}
