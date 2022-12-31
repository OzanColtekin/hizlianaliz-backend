using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UIProject.ViewComponents.Alert
{
    public class AlertList : ViewComponent
    {
        Context context = new();
        public IViewComponentResult Invoke()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            var alerts = context.Alerts.Where(x => x.UserID == inf.UserID && x.isRead != true).ToList();
            return View(alerts);
        }
    }
}
