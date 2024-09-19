using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
       
        [Precision(18,2)]
        public decimal TotalAmount { get; set; }
        public string Status { get;set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
        public Customer Customer { get; set; }
    }
}
