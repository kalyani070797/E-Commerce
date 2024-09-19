
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Model.Ecommerces.Inventories;
using E_Commerce.Model.Inventories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Ecommerces.Products
{
    public class ProductRequestModel
    {
        public int VendorId { get; set; }
        public int CatergoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<InvertoryRequestModel> Inventory { get; set; }
        public InventoryRequestModelForListOfItemSIngleProductId InventoryRequestModelForListOfItemSIngleProductId { get; set; }
    }
}
