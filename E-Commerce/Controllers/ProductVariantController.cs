using E_Commerce.Core.ProductVariants.Interface;
using E_Commerce.Model;
using E_Commerce.Model.ProdutVariant;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantController(
                                            IProductVariantCreator productVariantCreator) : ControllerBase
    {
        // GET: api/<ProductVariantController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductVariantController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductVariantController>
        [HttpPost]
        public CommonApi Post([FromBody] ProductVariantRequestModel productVariantRequestModel)
        {
            productVariantCreator.CreateProductVariant(productVariantRequestModel);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }

        // PUT api/<ProductVariantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductVariantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
