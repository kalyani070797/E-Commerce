using E_Commerce.Core.Products.Interface;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Products.Implementation
{
    public class ProductInformationByContains(ECommerceDbContext eCommerceDb) : IProductInformationByContains
    {
        public List<ProductResponseModel> GetInformationByContains(string Name)
        {
            var getInformationByCategoryContains = eCommerceDb.Product
                .Where(i => i.ProductName.Contains(Name))
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
            return getInformationByCategoryContains;
        }
    }
}
