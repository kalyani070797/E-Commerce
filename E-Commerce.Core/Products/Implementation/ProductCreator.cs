using E_Commerce.Core.Products.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Products.Implementation
{
    public class ProductCreator(ECommerceDbContext eCommerceDb) : IProductCreator
    {
        public void CreateProduct(ProductRequestModel productRequestModel)
        {
            var createProduct = new Product()
            {
                VendorId = productRequestModel.VendorId,
                CatergoryId = productRequestModel.CatergoryId,
                ProductName = productRequestModel.ProductName,
                Description = productRequestModel.Description,
                Price = productRequestModel.Price,
                StockQuantity = productRequestModel.StockQuantity,
                CreatedOn = productRequestModel.CreatedOn,
                ImageUrl = productRequestModel.ImageUrl,
            };
            eCommerceDb.Product.Add(createProduct);
            eCommerceDb.SaveChanges();
        }
    }
}
