﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Models.Request
{
    public class OrderRequest
    {
        public List<ProductSellRequest> ProductDetails { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public decimal TotamAmount { get; set; }
    }
}
