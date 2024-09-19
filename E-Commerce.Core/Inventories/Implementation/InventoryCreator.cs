using E_Commerce.Core.Inventories.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Inventories.Implementation
{
    public class InventoryCreator(ECommerceDbContext eCommerceDb) : IInventoryCreator
    {
        public void CreateInventory(InvertoryRequestModel invertoryRequestModel)
        {
            var createInventory = new Inventory()
            {
                ProductId = invertoryRequestModel.ProductId,
                ProductVariantId = invertoryRequestModel.ProductVariantId,
                Quantity = invertoryRequestModel.Quantity,
                ActualPrice = invertoryRequestModel.ActualPrice,
                DiscountPrice = invertoryRequestModel.DiscountPrice,
            };
            eCommerceDb.Inventory.Add(createInventory);
            eCommerceDb.SaveChanges();
        }
    }
}
