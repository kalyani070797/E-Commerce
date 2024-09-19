using E_Commerce.Model.Ecommerces.Inventories;

namespace E_Commerce.Core.Inventories.Interface
{
    public interface IInventoryCreator
    {
        void CreateInventory(InvertoryRequestModel invertoryRequestModel);
    }
}