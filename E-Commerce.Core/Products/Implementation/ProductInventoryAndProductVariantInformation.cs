using E_Commerce.Core.Products.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Products.Implementation
{
    public class ProductInventoryAndProductVariantInformation(ECommerceDbContext eCommerceDb) : IProductInventoryAndProductVariantInformation
    {
        public ProductResponseModelForAll GetProductInventoryAndProductVariant(int productId)
        {
            var getProductInventoryAndProductVariant = eCommerceDb.Product
                                                     .Include(i => i.Inventory)
                                                     //.ThenInclude(i => i.ProductVariant)
                                                     .Where(i => i.ProductId == productId)
                                                     .Select(i => new ProductResponseModelForAll
                                                     {
                                                         ProductId = i.ProductId,
                                                         CatergoryId = i.CatergoryId,
                                                         ProductName = i.ProductName,
                                                         Description = i.Description,
                                                         Price = i.Price,
                                                         StockQuantity = i.StockQuantity,
                                                         CreatedOn = i.CreatedOn,
                                                         ImageUrl = i.ImageUrl,
                                                         Inventory = i.Inventory,
                                                         InventoryModel = i.Inventory.Select(i => new InventoryModel
                                                         {
                                                             InventoryId = i.InventoryId,
                                                             ProductId = i.ProductId,
                                                             ProductVariantId = i.ProductVariantId,
                                                             Quantity = i.Quantity,
                                                             ActualPrice = i.ActualPrice,
                                                             DiscountPrice = i.DiscountPrice,
                                                             ProductVariantModel = i.ProductVariant
                                                             .Select(i => new ProductVariantModel
                                                             {
                                                                 ProductVariantId = i.ProductVariantId,
                                                                 ProductVariantMasterId = i.ProductVariantMasterId,
                                                                 VariantName = i.VariantName,
                                                             }).ToList(),

                                                         }).ToList(),
                                                     }).FirstOrDefault();
            return getProductInventoryAndProductVariant;
        }
    }
}
