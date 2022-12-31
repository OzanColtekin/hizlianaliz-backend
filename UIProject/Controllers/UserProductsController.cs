using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UIProject.Models.API;

namespace UIProject.Controllers
{
    public class UserProductsController : Controller
    {
        private readonly Context context = new();
        readonly TrendyolAPI trendyolAPI = new();
        public IActionResult Index()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            ViewBag.UserName = inf.UserName + " " + inf.UserSurName;
            ViewBag.isAdmin = inf.IsAdmin;
            ViewBag.DarkTheme = inf.DarkMode;
            ViewBag.alertcount = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).Count();
            ViewBag.Picture = inf.PictureURL;
            ViewBag.MessageCount = 0;
            var products = context.UserProducts.Where(x => x.UserID == inf.UserID).ToList();
            return View(products);
        }
        [HttpPost]
        public ActionResult UpdateProduct()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            trendyolAPI.GetProduct(inf.UserID);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult GetProduct(int id)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            if (inf == null) return RedirectToAction("index", "Login");
            ViewBag.UserName = inf.UserName + " " + inf.UserSurName;
            ViewBag.isAdmin = inf.IsAdmin;
            ViewBag.alertcount = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).Count();
            ViewBag.Picture = inf.PictureURL;
            var urun = context.UserProducts.Find(id);
            return View(urun);
        }

        public ActionResult EditProduct(UserProducts userProducts)
        {
            trendyolAPI.UpdateStockandPrice(userProducts);
            return RedirectToAction("index");
        }
    }
}
