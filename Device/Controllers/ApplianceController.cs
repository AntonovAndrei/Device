using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device.Controllers
{
    [ApiController]
    [Route("appliances")]
    public class ApplianceController
    {
        private static IEnumerable<Appliance> _appliance = new[]
        {
            new Appliance
            {
                Name = "Appliance",
                Description = "Appliance Description"
            },
            new Appliance
            {
                Name = "Appliance2",
                Description = "Appliance Description2"
            },
            new Appliance
            {
                Name = "Appliance3",
                Description = "Appliance Description3"
            }
        };

        [HttpGet]
        public IEnumerable<Appliance> Get()
        {
            return _appliance.ToArray();
        }
    }
}
