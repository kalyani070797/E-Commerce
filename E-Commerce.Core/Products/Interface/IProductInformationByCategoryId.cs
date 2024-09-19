using E_Commerce.Model.Products;

namespace E_Commerce.Core.Products.Interface
{
    public interface IProductInformationByCategoryId
    {
        List<ProductResponseModel> GetProductInformationByCategoryId(int categoryId);
    }
}