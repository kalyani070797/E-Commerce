using E_Commerce.Core.Categories.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Catergories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Categories.Implementation
{
    public class CategoryCreator(ECommerceDbContext eCommerceDb) : ICategoryCreator
    {
        public void CreateCategory(CatergoryRequestModel catergoryRequestModel)
        {
            var createCategory = new Catergory()
            {
                Name = catergoryRequestModel.Name,
            };
            eCommerceDb.Catergory.Add(createCategory);
            eCommerceDb.SaveChanges();
        }
    }
}
