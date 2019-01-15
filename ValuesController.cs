using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers
{
    //[Route("api/[controller]")]
    [Produces("application/json")]
    [Route("api/Values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost("SomeController")]
        //[HttpPost]
        public IActionResult SomeController([FromBody] Class1 nameParametr)
        {
            if (nameParametr == null)
            {
                return BadRequest();
            }
            Console.WriteLine("Hello_Postman");
            return Ok(nameParametr);
        }
    }    
}
