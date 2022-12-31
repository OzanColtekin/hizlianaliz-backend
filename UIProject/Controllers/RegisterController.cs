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
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        readonly Context context = new ();
        readonly Crypto _crypto = new ();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string UserMail, string UserPassword)
        {
            var inf = context.Users.Where(x => x.UserMail == UserMail).FirstOrDefault();
            Dictionary<string, bool> key = new();
            if (inf != null)
            {
                key["result"] = false;
                return Json(JsonConvert.SerializeObject(key));
            }
            var pw = _crypto.GetSHA1(_crypto.GetMD5(UserPassword));
            var user = new Users
            {
                UserPassword = pw,
                UserName = "Null",
                CreatedAt = DateTime.Now,
                JoinedAt = DateTime.Now,
                IsAdmin = false,
                UserSurName = "Null",
                UserNickName = "Null",
                UserMail = UserMail
            };
            context.Users.Add(user);
            context.SaveChanges();
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserMail),
            };
            var useridentity = new ClaimsIdentity(claims, "a");
            ClaimsPrincipal claimsPrincipal = new(useridentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            key["result"] = true;
            var values = JsonConvert.SerializeObject(key);
            return Json(values);
        }
    }
}
