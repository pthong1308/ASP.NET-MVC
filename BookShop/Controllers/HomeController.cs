using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BookShop.Models;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new DatabaseContext())
            {
                var cheapBooks = db.Books.Take(3).ToList()
                                            .OrderBy(b => b.Price)
                                            .ThenBy(b => b.Title);
                return View(cheapBooks);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}