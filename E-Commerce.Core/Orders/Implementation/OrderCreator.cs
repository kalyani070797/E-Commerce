using E_Commerce.Core.Orders.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Orders.Implementation
{
    public class OrderCreator(ECommerceDbContext eCommerceDb) : IOrderCreator
    {
        public void CreateOrder(OrderRequestModel orderRequestModel)
        {
            var createOrder = new Order()
            {
                CustomerId = orderRequestModel.CustomerId,
                TotalAmount = orderRequestModel.TotalAmount,
                Status = orderRequestModel.Status,
                CreatedOn = orderRequestModel.CreatedOn,
            };
            eCommerceDb.Order.Add(createOrder);
            eCommerceDb.SaveChanges();
        }
    }
}
