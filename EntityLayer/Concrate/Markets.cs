using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Markets
    {
        [Key]
        public int MarketID { get; set; }
        public string MarketName { get; set; }
    }
}
