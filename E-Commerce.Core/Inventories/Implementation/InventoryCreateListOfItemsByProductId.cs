using E_Commerce.Core.Inventories.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Inventories;
using E_Commerce.Model.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Inventories.Implementation
{
    public class InventoryCreateListOfItemsByProductId(ECommerceDbContext eCommerceDb) : IInventoryCreateListOfItemsByProductId
    {
        public void CreateInventoryListOfItemsByProductId(int productId,List<InventoryRequestModelForListOfItemSIngleProductId> inventoryRequestModelForListOfItemSIngleProductId)
        {
            var createInventoryListOfItemsByProductId = inventoryRequestModelForListOfItemSIngleProductId
                .Select(inven => new Inventory()
            {
                ProductId =productId,
                ProductVariantId = inven.ProductVariantId,
                Quantity = inven.Quantity,
                ActualPrice = inven.ActualPrice,
                DiscountPrice = inven.DiscountPrice,
            }).ToList();
             
            eCommerceDb.Inventory.AddRange(createInventoryListOfItemsByProductId);
            eCommerceDb.SaveChanges();
        }
    }
}
