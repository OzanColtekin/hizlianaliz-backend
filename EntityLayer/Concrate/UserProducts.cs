using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class UserProducts
    {
        [Key]
        public int UserProductID { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public int Stock { get; set; }
        public decimal SalePrice { get; set; }
        public decimal ListPrice { get; set; }
        public string Description { get; set; }
        public string ImgURL { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }

    }
}
