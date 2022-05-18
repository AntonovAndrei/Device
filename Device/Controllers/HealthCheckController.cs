using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device.Controllers
{
    [ApiController]
    [Route("hc")]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("I'm fine");
        }
    }
}
