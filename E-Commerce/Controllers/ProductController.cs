using E_Commerce.Core.Products.Interface;
using E_Commerce.Model;
using E_Commerce.Model.Ecommerces.Products;
using E_Commerce.Model.Products;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(
                                     IProductCreator productCreator,
                                     IProductCreatorForInventory productCreatorForInventory,
                                     IProductInventoryAndProductVariantInformation productInventoryAndProductVariantInformation,
                                     IProductInformationByCategoryId productInformationByCategoryId,
                                     IProductInformationByContains productInformationByContains) : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("GetAllProductInventoryAndProductVariant")]
        public ProductResponseModelForAll GetAllProductInventoryAndProductVariant( int productId)
        {
           var get= productInventoryAndProductVariantInformation.GetProductInventoryAndProductVariant(productId);
            return get;

        }
        [HttpGet("ProductInformationByCategoryId")]
        public CommonApi GetProductInformationByCategoryId(int categoryId)
        {
            var get = productInformationByCategoryId.GetProductInformationByCategoryId(categoryId);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Data = get,

            };
        }
        [HttpGet("ProductInformationByContains")]
        public CommonApi GetProductInformationByContains(string name)
        {
            var get = productInformationByContains.GetInformationByContains(name);
            return new CommonApi
            {
                Data = get,
                StatusCode=System.Net.HttpStatusCode.OK,
            };

        }

        // POST api/<ProductController>
        [HttpPost]
        public CommonApi Post([FromBody] ProductRequestModel productRequestModel)
        {
            productCreator.CreateProduct(productRequestModel);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }
        [HttpPost("ProductPostForInventory")]
        public CommonApi ProductPostForInventory(ProductRequestModel productRequestModel)
        {
           productCreatorForInventory.CreateProductForInventory(productRequestModel);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }


        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
