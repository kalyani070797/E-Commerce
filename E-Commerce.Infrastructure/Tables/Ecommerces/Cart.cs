﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class Cart
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }        
        public int ProductId { get; set; }      
        public int Quantity { get;set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
