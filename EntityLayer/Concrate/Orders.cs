﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public double orderNumber { get; set; }
        public int UserID { get; set; }
        public virtual Users User { get; set; }

    }
}
