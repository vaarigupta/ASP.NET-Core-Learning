using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogAPIs.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Harry Potter", "Revolution 2020", "James Bond", "Science Fiction" };
        }

      
       
    }
}
