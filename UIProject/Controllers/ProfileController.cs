using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UIProject.Models;
using UIProject.Models.Security;

namespace UIProject.Controllers
{
    public class ProfileController : Controller
    {
        readonly Context context = new();
        readonly Crypto crypto = new();
        public IActionResult Index()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            ViewBag.DarkTheme = inf.DarkMode;
            ViewBag.UserName = inf.UserName + " " + inf.UserSurName;
            ViewBag.isAdmin = inf.IsAdmin;
            ViewBag.alertcount = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).Count();
            ViewBag.Picture = inf.PictureURL;
            ViewBag.MessageCount = 0;
            return View(inf);
        }
        [HttpGet]
        public IActionResult Update()
        {
            return RedirectToAction("Index","Dashboard");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserViewModel p)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            if(p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userImages/profiles/" + imagename;
                var stream = new FileStream(savelocation,FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                inf.PictureURL = (string)imagename;
            }
            inf.UserSurName = p.UserSurName;
            inf.Cinsiyet = p.Cinsiyet;
            inf.UserName = p.UserName;
            inf.Şehir = p.Şehir;
            context.Users.Update(inf);
            context.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            ViewBag.DarkTheme = inf.DarkMode;
            ViewBag.UserName = inf.UserName + " " + inf.UserSurName;
            ViewBag.isAdmin = inf.IsAdmin;
            ViewBag.alertcount = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).Count();
            ViewBag.Picture = inf.PictureURL;
            ViewBag.MessageCount = 0;
            return View();
        }
        [HttpPost]
        public IActionResult ChangePassword(string Password,string NewPassword)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            string crpw = crypto.GetSHA1(crypto.GetMD5(Password));
            Dictionary<string, bool> key = new()
            {
                ["result"] = false
            };
            if (inf.UserPassword != crpw) return Json(JsonConvert.SerializeObject(key));
            string newpw = crypto.GetSHA1(crypto.GetMD5(NewPassword));
            inf.UserPassword = newpw;
            context.Users.Update(inf);
            context.SaveChanges();
            key["result"] = true;
            return Json(JsonConvert.SerializeObject(key));
        }
    }
}
