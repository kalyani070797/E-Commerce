using E_Commerce.Model.Ecommerces.Customers;

namespace E_Commerce.Core.Customers.Interface
{
    public interface ICustomerCreator
    {
        void CreateCustomer(CustomerRequestModel customerRequestModel);
    }
}