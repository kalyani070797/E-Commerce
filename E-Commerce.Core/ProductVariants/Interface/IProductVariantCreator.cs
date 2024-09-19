using E_Commerce.Model.ProdutVariant;

namespace E_Commerce.Core.ProductVariants.Interface
{
    public interface IProductVariantCreator
    {
        void CreateProductVariant(ProductVariantRequestModel productVariantRequestModel);
    }
}