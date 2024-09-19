using E_Commerce.Infrastructure.Tables.Ecommerces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Products
{
    public class ProductResponseModel
    {
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public int CatergoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedOn { get; set; }
        //public Catergory Catergory { get; set; }
        //public Vendor Vendor { get; set; }
        public string ImageUrl { get; set; }
    }
}
