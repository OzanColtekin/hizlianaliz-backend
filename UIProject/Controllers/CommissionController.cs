using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace UIProject.Controllers
{
    public class CommissionController : Controller
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
            List<SelectListItem> deger = (from x in context.Categories.OrderBy(x => x.CategoryName).ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryID.ToString()
                                          }).ToList();
            ViewBag.cat = deger;
            return View();
        }
        public IActionResult List()
        {

            Dictionary<string, bool> result = new()
            {
                ["result"] = true
            };
            var values = JsonConvert.SerializeObject(result);
            return Json(values);
        }
    }
}
