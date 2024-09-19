using E_Commerce.Model.Ecommerces.ProductVariantMasters;

namespace E_Commerce.Core.ProductVariantMasters.Interface
{
    public interface IProductVariantMasterCreator
    {
        void CreateProductVariantMaster(ProductVariantMasterRequestModel productVariantMasterRequest);
    }
}