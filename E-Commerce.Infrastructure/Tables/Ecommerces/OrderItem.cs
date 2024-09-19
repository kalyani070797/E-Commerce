using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }        
        public int ProductId { get; set; }       
        public int Quantity { get; set; }
        [Precision(18,2)]
        public decimal Price { get;set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
