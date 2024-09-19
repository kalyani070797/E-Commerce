using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class ProductVariant
    {
        public int ProductVariantId { get; set; }
        public int ProductVariantMasterId { get; set; }
        public string VariantName { get; set; }
        public ProductVariantMaster ProductVariantMaster { get; set; }
    }
}
