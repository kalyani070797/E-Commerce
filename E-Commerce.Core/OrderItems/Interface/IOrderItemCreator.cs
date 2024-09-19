using E_Commerce.Model.Ecommerces.OrderItems;

namespace E_Commerce.Core.OrderItems.Interface
{
    public interface IOrderItemCreator
    {
        void CreateOrderItem(OrderItemRequestModel orderItemRequestModel);
    }
}