using E_Commerce.Core.Categories.Interface;
using E_Commerce.Model;
using E_Commerce.Model.Ecommerces.Catergories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryCreator categoryCreator) : ControllerBase
    {
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public CommonApi Post([FromBody] CatergoryRequestModel catergoryRequestModel)
        {
            categoryCreator.CreateCategory(catergoryRequestModel);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
