using E_Commerce.Model.Ecommerces.Carts;

namespace E_Commerce.Core.Carts.Interface
{
    public interface ICartCreator
    {
        void CreateCart(CartRequestModel cartRequestModel);
    }
}