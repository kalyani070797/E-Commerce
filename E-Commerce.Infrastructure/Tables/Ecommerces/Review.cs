using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }      
        public int ProductId { get; set; }      
        public int Rating { get;set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
