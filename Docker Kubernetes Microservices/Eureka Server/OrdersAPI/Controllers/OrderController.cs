using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OrdersAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        //private readonly IConfiguration config;

        //public OrderController(IConfiguration config)
        //{
        //    this.config = config;
        //}

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("")]
        public IActionResult GetOrders()
        {
            var o1 = new Order("Id1", 200);
            var o2 = new Order("Id2", 400);
            return Ok(new List<Order> { o1, o2 });
        }

    }
}
