using E_Commerce.Core.Carts.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Carts.Implementation
{
    public class CartCreator(ECommerceDbContext eCommerceDb) : ICartCreator
    {
        public void CreateCart(CartRequestModel cartRequestModel)
        {
            var createCart = new Cart()
            {
                CustomerId = cartRequestModel.CustomerId,
                ProductId = cartRequestModel.ProductId,
                Quantity = cartRequestModel.Quantity,
            };
            eCommerceDb.Cart.Add(createCart);
            eCommerceDb.SaveChanges();
        }
    }
}
