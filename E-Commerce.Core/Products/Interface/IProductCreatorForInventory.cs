using E_Commerce.Model.Ecommerces.Products;

namespace E_Commerce.Core.Products.Interface
{
    public interface IProductCreatorForInventory
    {
        void CreateProductForInventory(ProductRequestModel productRequestModel);
    }
}