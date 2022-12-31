using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int TrendyolID { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
