using E_Commerce.Core.OrderItems.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.OrderItems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.OrderItems.Implementation
{
    public class OrderItemCreator(ECommerceDbContext eCommerceDb) : IOrderItemCreator
    {
        public void CreateOrderItem(OrderItemRequestModel orderItemRequestModel)
        {
            var createOrderItem = new OrderItem()
            {
                OrderId = orderItemRequestModel.OrderId,
                ProductId = orderItemRequestModel.ProductId,
                Quantity = orderItemRequestModel.Quantity,
                Price = orderItemRequestModel.Price,
            };
            eCommerceDb.OrderItem.Add(createOrderItem);
            eCommerceDb.SaveChanges();
        }
    }
}
