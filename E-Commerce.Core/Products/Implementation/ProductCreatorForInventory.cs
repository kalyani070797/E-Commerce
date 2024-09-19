using E_Commerce.Core.Inventories.Implementation;
using E_Commerce.Core.Inventories.Interface;
using E_Commerce.Core.Products.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Products.Implementation
{
    public class ProductCreatorForInventory(ECommerceDbContext eCommerceDb,
                                            IInventoryCreateListOfItemsByProductId itemsByProductId ) : IProductCreatorForInventory
    {
        public void CreateProductForInventory(ProductRequestModel productRequestModel)
        {
            var product = new Product
            {
                VendorId = productRequestModel.VendorId,
                CatergoryId = productRequestModel.CatergoryId,
                ProductName = productRequestModel.ProductName,
                Description = productRequestModel.Description,
                Price = productRequestModel.Price,
                StockQuantity = productRequestModel.StockQuantity,
                CreatedOn = DateTime.UtcNow,
                ImageUrl = productRequestModel.ImageUrl,
                Inventory = new List<Inventory>()
            };

            itemsByProductId.CreateInventoryListOfItemsByProductId(ProductRequestModel.InventoryRequestModelForListOfItemSIngleProductId);


            foreach (var inv in productRequestModel.Inventory)
            {
                var inventory = new Inventory
                {
                    ProductVariantId = inv.ProductVariantId,
                    Quantity = inv.Quantity,
                    ActualPrice = inv.ActualPrice,
                    DiscountPrice = inv.DiscountPrice
                };
                product.Inventory.Add(inventory);

                eCommerceDb.Product.Add(product);
                eCommerceDb.SaveChanges();
            }







            //var product = new Product()
            //{
            //    VendorId = productRequestModel.VendorId,
            //    CatergoryId = productRequestModel.CatergoryId,
            //    ProductName = productRequestModel.ProductName,
            //    Description = productRequestModel.Description,
            //    Price = productRequestModel.Price,
            //    StockQuantity = productRequestModel.StockQuantity,
            //    CreatedOn = productRequestModel.CreatedOn,
            //    ImageUrl = productRequestModel.ImageUrl,
            //};
            //eCommerceDb.Product.Add(product);
            //eCommerceDb.SaveChanges();

            //var newin = productRequestModel.Inventory.Select(i => new Inventory
            //{

            //    ProductId = product.ProductId,
            //    ProductVariantId = i.ProductVariantId,
            //    Quantity = i.Quantity,
            //    ActualPrice = i.ActualPrice,
            //    DiscountPrice = i.DiscountPrice,
            //}).ToList();
            //eCommerceDb.Inventory.AddRange(newin);
            //eCommerceDb.SaveChanges();

        }
    }
}
