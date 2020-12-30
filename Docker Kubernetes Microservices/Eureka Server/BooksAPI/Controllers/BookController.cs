using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly IConfiguration config;

        //public BookController (IConfiguration config)
        //{
        //    this.config = config;
        //}

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Harry Potter", "Revolution 2020", "James Bond", "Science Fiction" };
        }


    }
}
