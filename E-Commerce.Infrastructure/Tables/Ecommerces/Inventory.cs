using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int ProductVariantId { get; set; }      
        public int Quantity { get; set; }
        [Precision(18,2)]
        public decimal ActualPrice { get; set; }
        [Precision(18,2)]
        public decimal DiscountPrice { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductVariant> ProductVariant { get; set; }
    }
}
