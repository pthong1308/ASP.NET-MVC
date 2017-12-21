using System.Linq;
using System.Web.Mvc;
using BookShop.Models;
using LinqKit;
using System.Net;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web;
using System.IO;
using System.Transactions;
using System;

namespace BookShop.Controllers
{
    public class CatalogController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Book
        public ActionResult Index()
        {
            var listBooks = db.Books.ToList()
                                    .OrderBy(b => b.Price)
                                    .ThenBy(b => b.Title);

            return View(listBooks);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Author,Price")]Book book)
        {
            try
            {
                if (ModelState.IsValid)
                    using (var scope = new TransactionScope())
                    {
                        //Save book item into database
                        db.Books.Add(book);
                        db.SaveChanges();

                        if (Request.Files.Count > 0)
                            Upload(book);

                        scope.Complete();

                        return RedirectToAction("Index", "Catalog");
                    }
                return View();
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(book);
        }

        // GET: /Book/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var book = db.Books.First(b => b.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Book/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Author,Price")]Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var scope = new TransactionScope())
                    {
                        //Save book item into database
                        db.Entry(book).State = EntityState.Modified;
                        db.SaveChanges();

                        if (Request.Files.Count > 0)
                            Upload(book);

                        scope.Complete();

                        return RedirectToAction("Index", "Catalog");
                    }
                }
                return View();
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(book);
        }

        // GET: /Book/List
        public ActionResult Search(string searchTerm)
        {
            
            var terms = searchTerm?.Split(' ') ?? new string[0];
            var predicate = terms.Aggregate(
                PredicateBuilder.New<Book>(string.IsNullOrEmpty(searchTerm)),
                (acc, term) => acc.Or(b => b.Title.Contains(term))
                                  .Or(b => b.Author.Contains(term)));

            var books = db.Books.AsExpandable()
                                .Where(predicate)
                                .OrderBy(b => b.Title)
                                .ToList();

            return View("List", books);
        }

        // GET: /Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var book = db.Books.First(b => b.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public FileResult GetUpload(string imageId, string bookId)
        {
            string path = Server.MapPath("~/App_Data/Images/");
            FileResult file;

            try
            {
                file = File(Path.Combine(path, imageId), "image");
                return file;
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to load images. Try again, and if the problem persists, see your system administrator.");
                return null;
            }
        }

        private void Upload(Book book)
        {
            string path = Server.MapPath("~/App_Data/Images/");

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var uploadFile = new UploadFile
                    {
                        BookId = book.Id
                    };

                    //Save the list of Book Ids into database
                    db.UploadFiles.Add(uploadFile);
                    db.SaveChanges();

                    //Save uploaded files on server
                    Request.Files[i].SaveAs(Path.Combine(path, uploadFile.Id.ToString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}