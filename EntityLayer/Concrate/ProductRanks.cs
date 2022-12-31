using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class ProductRanks
    {
        [Key]
        public int ProductRankID { get; set; }
        public int ProductBarcode { get; set; }
        public string ProductLink { get; set; }
        public string Keyword { get; set; }
        public int RankNumber { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }
    }
}
