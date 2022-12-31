using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UIProject.Controllers
{
    public class OrdersController : Controller
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
            var orders = context.Orders.Where(x => x.UserID == inf.UserID).ToList();
            return View(orders);
        }
    }
}
