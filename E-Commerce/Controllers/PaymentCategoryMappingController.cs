using E_Commerce.Core.ProductCategoriesMappings.Interface;
using E_Commerce.Model;
using E_Commerce.Model.Ecommerces.ProductCategoryMappings;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentCategoryMappingController(IProductCategoryMappingCreator productCategoryMappingCreator) : ControllerBase
    {
        // GET: api/<PaymentCategoryMappingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PaymentCategoryMappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaymentCategoryMappingController>
        [HttpPost]
        public CommonApi Post([FromBody] ProductCategoryMappingRequestModel productCategoryMappingRequest)
        {
            productCategoryMappingCreator.CreateProductCategoryMapping(productCategoryMappingRequest);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }

        // PUT api/<PaymentCategoryMappingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentCategoryMappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
