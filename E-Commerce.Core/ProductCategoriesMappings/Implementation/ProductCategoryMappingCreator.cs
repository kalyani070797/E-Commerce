using E_Commerce.Core.ProductCategoriesMappings.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.ProductCategoryMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.ProductCategoriesMappings.Implementation
{
    public class ProductCategoryMappingCreator(ECommerceDbContext eCommerceDb) : IProductCategoryMappingCreator
    {
        public void CreateProductCategoryMapping(ProductCategoryMappingRequestModel productCategoryMappingRequestModel)
        {
            var createProductCategoryMapping = new ProductCategoryMapping()
            {
                ProductId = productCategoryMappingRequestModel.ProductId,
                CatergoryId = productCategoryMappingRequestModel.CatergoryId,
            };
            eCommerceDb.ProductCategoryMapping.Add(createProductCategoryMapping);
            eCommerceDb.SaveChanges();
        }
    }
}
