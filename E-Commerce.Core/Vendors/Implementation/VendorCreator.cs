using E_Commerce.Core.Vendors.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Vendors.Implementation
{
    public class VendorCreator(ECommerceDbContext eCommerceDb) : IVendorCreator
    {
        public void CreateVendor(VendorRequestModel vendorRequestModel)
        {
            var createVendore = new Vendor()
            {
               // CustomerId = vendorRequestModel.CustomerId,
                CompanyName = vendorRequestModel.CompanyName,
                ContactName = vendorRequestModel.ContactName,
                Address = vendorRequestModel.Address,
                ContactNumber = vendorRequestModel.ContactNumber,
                Email = vendorRequestModel.Email,
            };
            eCommerceDb.Vendor.Add(createVendore);
            eCommerceDb.SaveChanges();
        }
    }
}
