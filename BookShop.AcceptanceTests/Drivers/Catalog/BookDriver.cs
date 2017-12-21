using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.Routing;
using System.Configuration;
using System.Collections.Generic;
using BookShop.Controllers;
using BookShop.Models;
using BookShop.AcceptanceTests.Support;
using BookShop.AcceptanceTests.Common;
using BookShop.UITests.Selenium.Config;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Moq;
using FluentAssertions;

namespace BookShop.AcceptanceTests.Drivers.Catalog
{
    public class BookDriver
    {
        private const decimal BookDefaultPrice = 10;

        private ActionResult _result;
        private CatalogController _controller;
        private readonly CatalogContext _context;

        public BookDriver(CatalogContext context)
        {
            _context = context;
            _controller = new CatalogController();
        }

        public void InsertBookToDB(Table Books)
        {
            using (var db = new DatabaseContext())
            {
                foreach (var row in Books.Rows)
                {
                    var book = new Book
                    {
                        Author = row["Author"],
                        Title = row["Title"],
                        Price = Books.Header.Contains("Price")
                            ? Convert.ToDecimal(row["Price"])
                            : BookDefaultPrice
                    };

                    _context.ReferenceBooks.Add(
                            Books.Header.Contains("Id") ? row["Id"] : book.Title,
                            book);

                    db.Books.Add(book);
                }

                db.SaveChanges();
            }
        }

        public void ShowBookDetails(Table shownBookDetails)
        {
            //Arrange
            var expectedBookDetails = shownBookDetails.Rows.Single();

            //Act
            var actualBookDetails = _result.Model<Book>();

            //Assert
            actualBookDetails.Should().Match<Book>(
                b => b.Title == expectedBookDetails["Title"]
                && b.Author == expectedBookDetails["Author"]
                && b.Price == decimal.Parse(expectedBookDetails["Price"]));
        }

        public void OpenBookDetails(string bookId)
        {
            var book = _context.ReferenceBooks.GetById(bookId);
            using (var controller = new CatalogController())
            {
                _result = controller.Details(book.Id);
            }
        }

        public void NavigateCreateBook()
        {
             _result = _controller.Create();
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

            //Save book item into ScenarioContext object so that we can get it in the next step (UploadImage)
            ScenarioContext.Current.Add("book", book);

            //Save the create action into ScenarioContext object so that we can get it in the next step (UploadImage)
            ScenarioContext.Current.Add("isCreated", "Y");
            //_result = _controller.Create(book);
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

        public void UpdateBook(decimal price)
        {
            string bookId = ScenarioContext.Current.Get<string>("bookId");
            var book = _context.ReferenceBooks.GetById(bookId);

            using (var db = new DatabaseContext())
            {
                var bookitem = db.Books.ToList().FirstOrDefault(b => b.Title == book.Title);

                bookitem.Price = price;

                //Save bookitem into ScenarioContext object so that we can get it in the next step (UploadImage)
                ScenarioContext.Current.Add("book", bookitem);
            }

            //Save the update action into ScenarioContext object so that we can get it in the next step (UploadImage)
            ScenarioContext.Current.Add("isCreated", "N");
        }

        public void UploadImage(string uploadFiles)
        {
            //Setup a fake HttpRequest
            Mock<HttpContextBase> moqContext = new Mock<HttpContextBase>();
            Mock<HttpRequestBase> moqRequest = new Mock<HttpRequestBase>();

            Mock<HttpFileCollectionBase> moqPostedFileCollection = new Mock<HttpFileCollectionBase>();
            Mock<HttpServerUtilityBase> moqServer = new Mock<HttpServerUtilityBase>();

            //FileStream fileStream = null;

            string imagePath = Path.Combine(ProjectLocation.FromFolder("BookShop").FullPath, @"App_Data\Images");
            moqServer.Setup(s => s.MapPath("~/App_Data/Images/")).Returns(imagePath);
            moqContext.Setup(x => x.Server).Returns(moqServer.Object);
            moqContext.Setup(x => x.Request).Returns(moqRequest.Object);

            IEnumerable<string> fileNames = from t in uploadFiles.Split(',')
                                            select t.Trim().Trim('\'');

            moqPostedFileCollection.Setup(c => c.Count).Returns(fileNames.Count()); ///
            moqRequest.Setup(r => r.Files).Returns(moqPostedFileCollection.Object);

            for (int i=0; i < fileNames.Count(); i++)
            {
                //string filePath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["ImageSource"] + fileNames.ElementAt(i));

                //fileStream = new FileStream(filePath, FileMode.Open);

                Mock<HttpPostedFileBase> moqPostedFile = new Mock<HttpPostedFileBase>();
                //moqPostedFile.Setup(p => p.FileName).Returns(fileNames.ElementAt(i));
                //moqPostedFile.Setup(p => p.InputStream).Returns(fileStream);
                //moqPostedFile.Setup(p => p.ContentType).Returns("image/jpg");
                //moqPostedFile.Setup(p => p.ContentLength).Returns((int)fileStream.Length);
                moqPostedFile.Setup(p => p.SaveAs(It.IsAny<string>())).Verifiable();
                
                moqPostedFileCollection.Setup(c => c[i]).Returns(moqPostedFile.Object); ///
            }

            //Pass the fake current HttpContext into the ControllerContext of CatalogController
            _controller.ControllerContext = new ControllerContext(moqContext.Object, new RouteData(), _controller);

            Book book = ScenarioContext.Current.Get<Book>("book");

            //Get the action from ScenarioContext object so that we can call the suitable action in CatalogController (Create/Edit Book)
            if (ScenarioContext.Current.Get<string>("isCreated") == "Y")
                _result = _controller.Create(book);
            else
                _result = _controller.Edit(book);

            //fileStream.Close();
        }

        public void SaveImages()
        {
            //Get the book item from ScenarioContext object (saved in the step of Create/Edit Book)
            Book book = ScenarioContext.Current.Get<Book>("book");

            //Arrange
            ActionResult result = _controller.Index();
            var bookLists = result.Model<IEnumerable<Book>>();

            //Get the image list of created/edited book item from table UploadFiles so that we can get the name of uploaded images 
            var db = new DatabaseContext();
            var uploadFiles = db.UploadFiles.ToList().Where(u => bookLists.Where(b => b.Title == book.Title).Select(b => b.Id).Contains(u.BookId)).OrderBy(u => u.Id).ToList();

            //Act
            var moqRequest = Mock.Get<HttpRequestBase>(_controller.Request);

            //Assert
            for (int i=0; i<uploadFiles.Count(); i++)
            {
                string filePath = Path.Combine(_controller.Server.MapPath("~/App_Data/Images/"), uploadFiles[i].Id.ToString());

                //Verify whether uploaded images saved on server by checking whether the fake current HttpRequest has invoked SaveAs method
                Mock.Get<HttpPostedFileBase>(_controller.Request.Files[i]).Verify(r => r.SaveAs(filePath));
            }
        }
    }
}
