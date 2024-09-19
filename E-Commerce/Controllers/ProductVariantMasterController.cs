using E_Commerce.Core.ProductVariantMasters.Interface;
using E_Commerce.Model;
using E_Commerce.Model.Ecommerces.ProductVariantMasters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantMasterController(
                                                  IProductVariantMasterCreator productVariantMasterCreator) : ControllerBase
    {
        // GET: api/<ProductVariantMasterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductVariantMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductVariantMasterController>
        [HttpPost]
        public CommonApi Post([FromBody] ProductVariantMasterRequestModel productVariantMasterRequest)
        {
            productVariantMasterCreator.CreateProductVariantMaster(productVariantMasterRequest);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }

        // PUT api/<ProductVariantMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductVariantMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
