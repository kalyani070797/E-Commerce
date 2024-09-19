using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Tables.Ecommerces
{
    public class ProductCategoryMapping
    {
        public int ProductCategoryMappingId { get; set; }
        public int ProductId { get; set; }       
        public int CatergoryId { get; set; }
        public Catergory Catergory { get; set; }
        public Product Product { get; set; }
    }
}
