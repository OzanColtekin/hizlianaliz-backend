using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace UIProject.Controllers
{
    public class PriceTrackController : Controller
    {
        private readonly Context context = new();
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
            var prdc = context.ProductPrices.Where(x => x.UserProductPrice.UserID == inf.UserID).ToList();
            var prodc = (from x in context.ProductPrices
                         join y in context.UserProductPrices on x.ProductBarcode equals y.ProductBarcode
                         where y.UserID == inf.UserID
                         select x).ToList();
            return View(prdc);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(string url)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            UserProductPrices product = new()
            {
                ProductBarcode = "0",
                ProductUrl = url,
                UserID = inf.UserID
            };
            context.UserProductPrices.Add(product);
            context.SaveChanges();
            Dictionary<string, bool> key = new()
            {
                ["result"] = true
            };
            return Json(JsonConvert.SerializeObject(key));
        }
    }
}
