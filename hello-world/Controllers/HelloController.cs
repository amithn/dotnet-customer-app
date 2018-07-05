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
    public class HelloController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Hello("Hello from the .NET app running on Cloud Foundry the time here is : " 
                                                                            + DateTime.Now.ToString()));
        }

    }
}
