using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class BuyboxTrack
    {
        [Key]
        public int BuyboxID { get; set; }
        public string ProductURL { get; set; }
        public bool IsBuyBox { get; set; }
        public int UserID { get; set; }
        public virtual Users user { get; set; }

    }
}
