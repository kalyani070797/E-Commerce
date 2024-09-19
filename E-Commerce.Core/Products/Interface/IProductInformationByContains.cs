using E_Commerce.Model.Products;

namespace E_Commerce.Core.Products.Interface
{
    public interface IProductInformationByContains
    {
        List<ProductResponseModel> GetInformationByContains(string Name);
    }
}