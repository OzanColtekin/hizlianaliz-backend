using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class UserAPIs
    {
        [Key]
        public int UserAPIID { get; set; }
        
        public int SellerID { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }
        public int MarketID { get; set; }
        public virtual Markets Market { get; set; }

    }
}
