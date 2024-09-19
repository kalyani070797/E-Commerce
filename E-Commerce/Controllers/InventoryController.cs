using E_Commerce.Core.Inventories.Interface;
using E_Commerce.Model;
using E_Commerce.Model.Ecommerces.Inventories;
using E_Commerce.Model.Inventories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController(
                                       IInventoryCreator inventoryCreator,
                                       IInventoryCreateListOfItemsByProductId inventoryCreateListOfItemsByProductId) : ControllerBase
    {
        // GET: api/<InventoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost("InventoryCreateListOfItemsByProductId")]
        public CommonApi PostInventoryCreateListOfItemsByProductId(int productId, List<InventoryRequestModelForListOfItemSIngleProductId> inventoryRequestModelForListOfItemSIngleProductId)
        {
            inventoryCreateListOfItemsByProductId.CreateInventoryListOfItemsByProductId(productId ,inventoryRequestModelForListOfItemSIngleProductId);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Multiple Record Inserted With Single ProductId"
            };
        }


        // POST api/<InventoryController>
        [HttpPost]
        public CommonApi Post([FromBody] InvertoryRequestModel invertoryRequestModel)
        {
            inventoryCreator.CreateInventory(invertoryRequestModel);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
