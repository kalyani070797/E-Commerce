using E_Commerce.Core.ProductVariants.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.ProdutVariant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.ProductVariants.Implementation
{
    public class ProductVariantCreator(ECommerceDbContext eCommerceDb) : IProductVariantCreator
    {
        public void CreateProductVariant(ProductVariantRequestModel productVariantRequestModel)
        {
            var createProductVariant = new ProductVariant()
            {
                ProductVariantMasterId = productVariantRequestModel.ProductVariantMasterId,
                VariantName = productVariantRequestModel.VariantName,
            };
            eCommerceDb.ProductVariant.Add(createProductVariant);
            eCommerceDb.SaveChanges();
        }
    }
}
