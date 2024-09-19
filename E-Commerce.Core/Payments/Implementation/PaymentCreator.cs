using E_Commerce.Core.Payments.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Payments.Implementation
{
    public class PaymentCreator(ECommerceDbContext eCommerceDb) : IPaymentCreator
    {
        public void CreatePayment(PaymentRequestModel paymentRequestModel)
        {
            var createPayment = new Payment()
            {
                OrderId = paymentRequestModel.OrderId,
                PaymentMethod = paymentRequestModel.PaymentMethod,
                Amount = paymentRequestModel.Amount,
                Status = paymentRequestModel.Status,
                CreatedOn = paymentRequestModel.CreatedOn,
            };
            eCommerceDb.Payment.Add(createPayment);
            eCommerceDb.SaveChanges();
        }
    }
}
