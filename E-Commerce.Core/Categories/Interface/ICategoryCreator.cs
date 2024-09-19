using E_Commerce.Model.Ecommerces.Catergories;

namespace E_Commerce.Core.Categories.Interface
{
    public interface ICategoryCreator
    {
        void CreateCategory(CatergoryRequestModel catergoryRequestModel);
    }
}