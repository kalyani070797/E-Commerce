using E_Commerce.Model.Products;

namespace E_Commerce.Core.Products.Interface
{
    public interface IProductInventoryAndProductVariantInformation
    {
        ProductResponseModelForAll GetProductInventoryAndProductVariant(int productId);
    }
}