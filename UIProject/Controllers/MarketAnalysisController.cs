using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UIProject.Controllers
{
    public class MarketAnalysisController : Controller
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
            List<SelectListItem> deger = (from x in context.Categories.OrderBy(x=> x.CategoryName).ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.CategoryName,
                                             Value = x.CategoryID.ToString()
            }).ToList();
            ViewBag.cat = deger;
            return View();
        }
        [HttpGet]
        public IActionResult GetCategory()
        {
            return RedirectToAction("Index","MarketAnalysis");
        }
        [HttpPost]
        public IActionResult GetCategory(int CategoryID)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            ViewBag.UserName = inf.UserName + " " + inf.UserSurName;
            ViewBag.isAdmin = inf.IsAdmin;
            ViewBag.DarkTheme = inf.DarkMode;
            ViewBag.alertcount = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).Count();
            ViewBag.Picture = inf.PictureURL;
            ViewBag.MessageCount = 0;
            var products = context.Products.Where(x => x.CategoryID == CategoryID).ToList();
            ViewBag.CatAvg = Math.Round(products.Average(x => x.Price),2);
            ViewBag.CatMax = products.Max(x => x.Price);
            ViewBag.CatMin = products.Min(x => x.Price);
            ViewBag.BrandCount = products.GroupBy(x => x.ProductBrand).Count();
            if (products.Count == 0) return RedirectToAction("Index", "MarketAnalysis");
            return View(products);
        }
    }
}
