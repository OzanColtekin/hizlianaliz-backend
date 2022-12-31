using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Alerts
    {
        [Key]
        public int AlertID { get; set; }
        public string AlertText { get; set; }
        public DateTime date { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }
        public bool isRead { get; set; }
        public bool isDelete { get; set; }
    }
}
