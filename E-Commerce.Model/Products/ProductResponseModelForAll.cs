using E_Commerce.Infrastructure.Tables.Ecommerces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Products
{
    public class ProductResponseModelForAll
    {
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public int CatergoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedOn { get; set; }
        //public Catergory Catergory { get; set; }
        //public Vendor Vendor { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public List<InventoryModel> InventoryModel{get  ;set; }
    }

    public class ProductVariantModel
    {
        public int ProductVariantId { get; set; }
        public int ProductVariantMasterId { get; set; }
        public string VariantName { get; set; }
    }
    public class InventoryModel
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int ProductVariantId { get; set; }
        public int Quantity { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public List<ProductVariantModel> ProductVariantModel { get; set; }
    }


}
