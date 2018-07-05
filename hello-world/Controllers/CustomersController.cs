using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using customer.experience;

namespace customer.experience.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
       
        // GET /customers/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST /customers
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            customer.name = customer.name.ToUpper();
            return Ok(customer);
        }

        // PUT /customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE customers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
