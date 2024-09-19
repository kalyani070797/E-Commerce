using E_Commerce.Model.Ecommerces.ProductCategoryMappings;

namespace E_Commerce.Core.ProductCategoriesMappings.Interface
{
    public interface IProductCategoryMappingCreator
    {
        void CreateProductCategoryMapping(ProductCategoryMappingRequestModel productCategoryMappingRequestModel);
    }
}