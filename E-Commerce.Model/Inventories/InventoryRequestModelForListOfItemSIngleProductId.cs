using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Inventories
{
    public class InventoryRequestModelForListOfItemSIngleProductId
    {
        public int ProductId { get; set; }
        public int ProductVariantId { get; set; }
        public int Quantity { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}
