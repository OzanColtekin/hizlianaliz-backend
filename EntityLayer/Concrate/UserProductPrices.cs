using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class UserProductPrices
    {
        [Key]
        public int UserProductPriceID { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductUrl { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }
        public ICollection<ProductPrices> ProductPrices { get; set; }

    }
}
