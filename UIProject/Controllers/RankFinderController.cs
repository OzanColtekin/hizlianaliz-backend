using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using UIProject.Models.API;

namespace UIProject.Controllers
{
    public class RankFinderController : Controller
    {
        private readonly Context context = new();
        readonly TrendyolAPI trendyolAPI = new();
        public IActionResult Index()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            if (trendyolAPI.checkAPI(inf.UserID) == false) return RedirectToAction("Index", "API");
            ViewBag.UserName = inf.UserName + " " + inf.UserSurName;
            ViewBag.isAdmin = inf.IsAdmin;
            ViewBag.DarkTheme = inf.DarkMode;
            ViewBag.alertcount = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).Count();
            ViewBag.Picture = inf.PictureURL;
            ViewBag.MessageCount = 0;
            var prodc = context.ProductRanks.Where(x => x.UserID == inf.UserID).ToList();
            return View(prodc);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(string url, string keyword)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            ProductRanks product = new()
            {
                Keyword = keyword,
                ProductLink = url,
                RankNumber = 1,
                ProductBarcode = 0,
                Date = DateTime.Now,
                UserID = inf.UserID
            };
            context.ProductRanks.Add(product);
            context.SaveChanges();
            Dictionary<string, bool> key = new()
            {
                ["result"] = true
            };
            return Json(JsonConvert.SerializeObject(key));
        }
    }
}
