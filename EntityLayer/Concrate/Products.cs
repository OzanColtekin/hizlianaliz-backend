using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductBrand { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPoint { get; set; }
        public int Favories { get; set; }
        public decimal SellerPoint { get; set; }
        public bool IsFreeCargo { get; set; }
        public decimal RatingCount { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int CategoryID { get; set; }
        public int PhotoCount { get; set; }
        public int SallerCount { get; set; }
        public int CargoRemainingDay { get; set; }
        public int FeaturesCount { get; set; }
        public virtual Categories Category { get; set; }
    }
}
