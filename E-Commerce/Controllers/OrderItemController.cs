﻿using E_Commerce.Core.OrderItems.Interface;
using E_Commerce.Model;
using E_Commerce.Model.Ecommerces.OrderItems;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController(IOrderItemCreator orderItemCreator) : ControllerBase
    {
        // GET: api/<OrderItemController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderItemController>
        [HttpPost]
        public CommonApi Post([FromBody] OrderItemRequestModel orderItemRequestModel)
        {
            orderItemCreator.CreateOrderItem(orderItemRequestModel);
            return new CommonApi
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record Inserted Succefully"
            };
        }

        // PUT api/<OrderItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
