using Microsoft.AspNetCore.Http;

namespace UIProject.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string Şehir { get; set; }
        public string PictureURL { get; set; }
        public string Cinsiyet { get; set; }
        public IFormFile Picture { get; set; }
    }
}
