using E_Commerce.Model.Ecommerces.Vendors;

namespace E_Commerce.Core.Vendors.Interface
{
    public interface IVendorCreator
    {
        void CreateVendor(VendorRequestModel vendorRequestModel);
    }
}