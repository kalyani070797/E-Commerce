using E_Commerce.Core.ProductVariantMasters.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.ProductVariantMasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.ProductVariantMasters.Implementation
{
    public class ProductVariantMasterCreator(ECommerceDbContext eCommerceDb) : IProductVariantMasterCreator
    {
        public void CreateProductVariantMaster(ProductVariantMasterRequestModel productVariantMasterRequest)
        {
            var createProductVariantMaster = new ProductVariantMaster()
            {
                Name = productVariantMasterRequest.Name,
            };
            eCommerceDb.ProductVariantMaster.Add(createProductVariantMaster);
            eCommerceDb.SaveChanges();
        }
    }
}
