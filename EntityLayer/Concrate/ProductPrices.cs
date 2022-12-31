using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class ProductPrices
    {
        [Key]
        public int ProductPriceID { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductUrl { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public int UserProductPriceID { get; set; }
        public virtual UserProductPrices UserProductPrice { get; set; }
    }
}
