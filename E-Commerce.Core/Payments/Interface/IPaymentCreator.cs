using E_Commerce.Model.Ecommerces.Payments;

namespace E_Commerce.Core.Payments.Interface
{
    public interface IPaymentCreator
    {
        void CreatePayment(PaymentRequestModel paymentRequestModel);
    }
}