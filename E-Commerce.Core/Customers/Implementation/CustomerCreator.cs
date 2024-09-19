using E_Commerce.Core.Customers.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Customers.Implementation
{
    public class CustomerCreator(ECommerceDbContext eCommerceDb) : ICustomerCreator
    {
        public void CreateCustomer(CustomerRequestModel customerRequestModel)
        {
            var createCustomer = new Customer()
            {
                CustomerName = customerRequestModel.CustomerName,
                ContactNumber = customerRequestModel.ContactNumber,
                Address = customerRequestModel.Address,
                Email = customerRequestModel.Email,
                Password = customerRequestModel.Password,
            };
            eCommerceDb.Customer.Add(createCustomer);
            eCommerceDb.SaveChanges();
        }
    }
}
