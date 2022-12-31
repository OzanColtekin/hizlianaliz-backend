using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UIProject.Models.Security;

namespace UIProject.Controllers
{
    public class LoginController : Controller
    {
        readonly Context context = new();
        readonly Crypto _crypto = new();
        [AllowAnonymous]
        public IActionResult Index()
        {
            string mail = HttpContext.User.Identity.Name;
            var inf = context.Users.FirstOrDefault(x => x.UserMail == mail);
            if (inf != null) return RedirectToAction("Index", "Dashboard");
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> LogIN(string UserMail, string UserPassword)
        {
            var pw = _crypto.GetSHA1(_crypto.GetMD5(UserPassword));
            var data = context.Users.FirstOrDefault(x => x.UserMail == UserMail && x.UserPassword == pw);
            Dictionary<string, bool> key = new()
            {
                ["result"] = false
            };
            if (data == null) return Json(JsonConvert.SerializeObject(key));
            data.JoinedAt = DateTime.Now;
            context.Users.Update(data);
            context.SaveChanges();
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, UserMail),
            };
            var useridentity = new ClaimsIdentity(claims,"a");
            ClaimsPrincipal claimsPrincipal = new(useridentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            key["result"] = true;
            return Json(JsonConvert.SerializeObject(key));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
