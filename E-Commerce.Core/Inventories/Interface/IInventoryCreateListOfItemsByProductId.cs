using E_Commerce.Model.Inventories;

namespace E_Commerce.Core.Inventories.Interface
{
    public interface IInventoryCreateListOfItemsByProductId
    {
        void CreateInventoryListOfItemsByProductId(int productId, List<InventoryRequestModelForListOfItemSIngleProductId> inventoryRequestModelForListOfItemSIngleProductId);
    }
}