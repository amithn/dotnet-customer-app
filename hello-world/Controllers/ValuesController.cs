using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using helloworld;

namespace hello_world.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "Pivotal", "Clouds", "Foundry" };
        //}

        [HttpGet]
        public IActionResult Get()

        {
            return Ok(new Hello("Hello from Cloud Foundry the time here is : " 
                                + DateTime.Now.ToString()));
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            Console.WriteLine(customer.name);
            customer.name = customer.name.ToUpper();
            return Ok(customer);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
