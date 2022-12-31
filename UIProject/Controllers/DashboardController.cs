using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UIProject.Controllers
{
    public class DashboardController : Controller
    {
        readonly Context context = new();
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
            return View();
        }

        public IActionResult ChangeTheme()
        {
            string mail = HttpContext.User.Identity.Name;
            var theme = context.Users.FirstOrDefault(x => x.UserMail == mail).DarkMode;
            if(theme == true)
            {
                context.Users.FirstOrDefault(x => x.UserMail == mail).DarkMode = false;
                context.SaveChanges();
            }
            else
            {
                context.Users.FirstOrDefault(x => x.UserMail == mail).DarkMode = true;
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
