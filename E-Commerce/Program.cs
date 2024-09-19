using E_Commerce.Core.Carts.Implementation;
using E_Commerce.Core.Carts.Interface;
using E_Commerce.Core.Categories.Implementation;
using E_Commerce.Core.Categories.Interface;
using E_Commerce.Core.Customers.Implementation;
using E_Commerce.Core.Customers.Interface;
using E_Commerce.Core.Inventories.Implementation;
using E_Commerce.Core.Inventories.Interface;
using E_Commerce.Core.OrderItems.Implementation;
using E_Commerce.Core.OrderItems.Interface;
using E_Commerce.Core.Orders.Implementation;
using E_Commerce.Core.Orders.Interface;
using E_Commerce.Core.Payments.Implementation;
using E_Commerce.Core.Payments.Interface;
using E_Commerce.Core.ProductCategoriesMappings.Implementation;
using E_Commerce.Core.ProductCategoriesMappings.Interface;
using E_Commerce.Core.Products.Implementation;
using E_Commerce.Core.Products.Interface;
using E_Commerce.Core.ProductVariantMasters.Implementation;
using E_Commerce.Core.ProductVariantMasters.Interface;
using E_Commerce.Core.ProductVariants.Implementation;
using E_Commerce.Core.ProductVariants.Interface;
using E_Commerce.Core.Reviews.Implementation;
using E_Commerce.Core.Reviews.Interface;
using E_Commerce.Core.Vendors.Implementation;
using E_Commerce.Core.Vendors.Interface;














//using E_Commerce.Core.Ecommerces.Users.Implementation;
//using E_Commerce.Core.Ecommerces.Users.Interface;
using E_Commerce.Infrastructure.UseDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("ECommerceDb");
builder.Services.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(connection));



//Customer
builder.Services.AddScoped<ICustomerCreator,  CustomerCreator>();

//Inventory
builder.Services.AddScoped<IInventoryCreator,  InventoryCreator>();
builder.Services.AddScoped<IInventoryCreateListOfItemsByProductId,  InventoryCreateListOfItemsByProductId>();

//Cart
builder.Services.AddScoped<ICartCreator, CartCreator>();

//Order
builder.Services.AddScoped<IOrderCreator, OrderCreator>();

//OrderItem
builder.Services.AddScoped<IOrderItemCreator, OrderItemCreator>();

//Payment
builder.Services.AddScoped<IPaymentCreator, PaymentCreator>();

//ProductCategoryMapping
builder.Services.AddScoped<IProductCategoryMappingCreator, ProductCategoryMappingCreator>();

//Product
builder.Services.AddScoped<IProductCreator,  ProductCreator>();
builder.Services.AddScoped<IProductCreatorForInventory,  ProductCreatorForInventory>();
builder.Services.AddScoped<IProductInventoryAndProductVariantInformation,  ProductInventoryAndProductVariantInformation>();
builder.Services.AddScoped<IProductInformationByCategoryId,  ProductInformationByCategoryId>();
builder.Services.AddScoped<IProductInformationByContains,  ProductInformationByContains>();


//Review
builder.Services.AddScoped<IReviewCreator,  ReviewCreator>();

//Category
builder.Services.AddScoped<ICategoryCreator, CategoryCreator>();

//Vendor
builder.Services.AddScoped<IVendorCreator,  VendorCreator>();

//ProductVariantMaster
builder.Services.AddScoped<IProductVariantMasterCreator,  ProductVariantMasterCreator>();

//ProductVariant
builder.Services.AddScoped<IProductVariantCreator,  ProductVariantCreator>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
