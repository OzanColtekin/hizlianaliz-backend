using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UIProject.Controllers
{
    public class APIController : Controller
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
            return View();
        }
        [HttpPost]
        public ActionResult SaveAPI(int saticiID, string APIKEY, string APISECRET, int marketid)
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            if (context.UserAPIs.FirstOrDefault(x => x.UserID == inf.UserID && x.MarketID == marketid) == null)
            {
                UserAPIs userAPIs = new()
                {
                    SellerID = saticiID,
                    ApiKey = APIKEY,
                    ApiSecret = APISECRET,
                    MarketID = marketid,
                    UserID = inf.UserID
                };
                context.UserAPIs.Add(userAPIs);
                context.SaveChanges();
            }
            else
            {
                var api = context.UserAPIs.FirstOrDefault(x => x.UserID == inf.UserID && x.MarketID == marketid);
                api.SellerID = saticiID;
                api.ApiKey = APIKEY;
                api.ApiSecret = APISECRET;
                context.SaveChanges();
            }

            return RedirectToAction("index");
        }
    }
}
