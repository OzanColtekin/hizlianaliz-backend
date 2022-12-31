using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UIProject.ViewComponents.DashboardAlert
{
    public class DashboardAlertList : ViewComponent
    {
        Context context = new();
        public IViewComponentResult Invoke()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            var products = context.UserProducts.Where(X=> X.Stock < 5).FirstOrDefault();
            ViewBag.stock = products.Stock;
            ViewBag.stockProd = products.Title;
            var alerts = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).ToList();
            return View(alerts);
        }
    }
}
