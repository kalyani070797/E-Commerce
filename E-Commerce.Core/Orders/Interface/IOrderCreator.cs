using E_Commerce.Model.Ecommerces.Orders;

namespace E_Commerce.Core.Orders.Interface
{
    public interface IOrderCreator
    {
        void CreateOrder(OrderRequestModel orderRequestModel);
    }
}