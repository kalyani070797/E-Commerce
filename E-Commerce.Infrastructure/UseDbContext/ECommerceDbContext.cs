using E_Commerce.Infrastructure.Tables.Ecommerces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.UseDbContext
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customer { get;set;}
        public DbSet<Cart> Cart { get;set;}
        public DbSet<Order> Order { get;set;}
        public DbSet<Catergory> Catergory { get;set;}
        public DbSet<Inventory> Inventory { get;set;}
        public DbSet<OrderItem> OrderItem { get;set;}
        public DbSet<Payment> Payment { get;set;}
        public DbSet<Product> Product { get;set;}
        public DbSet<ProductCategoryMapping> ProductCategoryMapping { get;set;}
        public DbSet<Review> Review { get;set;}
       // public DbSet<User> User { get;set;}
        public DbSet<Vendor> Vendor { get;set;}
        public DbSet<ProductVariantMaster> ProductVariantMaster { get;set;}
        public DbSet<ProductVariant> ProductVariant { get;set;}
    }
}
