using Microsoft.AspNetCore.Mvc;
using OrderAPIs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPIs.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
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
