using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace UIProject.Controllers
{
    public class BuyBoxTrackerController : Controller
    {
        readonly Context context = new();
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
            var prdct = context.BuyboxTracks.Where(x => x.UserID == inf.UserID).ToList();
            return View(prdct);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(string url)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            var buyboxTrack = new BuyboxTrack()
            {
                ProductURL = url,
                UserID = inf.UserID
            };
            context.BuyboxTracks.Add(buyboxTrack);
            //context.SaveChanges();
            Dictionary<string, bool> key = new()
            {
                ["result"] = true
            };
            return Json(JsonConvert.SerializeObject(key));
        }
    }
}
