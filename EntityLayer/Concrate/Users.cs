using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string UserNickName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public bool IsAdmin { get; set; }
        public bool DarkMode { get; set; }
        public string PictureURL { get; set; }
        public string Cinsiyet { get; set; }
        public string Şehir { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime JoinedAt { get; set; }
        public ICollection<ProductRanks> ProductRanks { get; set; }
        public ICollection<UserProductPrices> UserProductsPrices { get; set; }
        public ICollection<Alerts> Alerts { get; set; }
    }
}
