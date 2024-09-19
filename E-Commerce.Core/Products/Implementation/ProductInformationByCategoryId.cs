using E_Commerce.Core.Products.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Products;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Products.Implementation
{
    public class ProductInformationByCategoryId(ECommerceDbContext eCommerceDb) : IProductInformationByCategoryId
    {
        public List<ProductResponseModel> GetProductInformationByCategoryId(int categoryId)
        {
            var getProductInformationByCategoryId = eCommerceDb.Product
                .Where(i => i.CatergoryId == categoryId)
                .Select(i => new ProductResponseModel
                {
                    ProductId = i.ProductId,
                    VendorId = i.VendorId,
                    CatergoryId = i.CatergoryId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    StockQuantity = i.StockQuantity,
                    CreatedOn = i.CreatedOn,
                    ImageUrl = i.ImageUrl,
                }).ToList();
            return getProductInformationByCategoryId;
        }
    }
}
