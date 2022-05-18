using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device.Controllers
{
    [ApiController]
    [Route("models")]
    public class ModelController : ControllerBase
    {
        private static IEnumerable<Model> _models = new[]
        {
            new Model
            {
                Name = "Mush",
                Manufacturer = "OtMsuh",
                Color = "blue",
                ApplianceName = "msuh",
                Description = "horoshiy"
            },
            new Model
            {
                Name = "Mush2",
                Manufacturer = "OtMsuh2",
                Color = "blue2",
                ApplianceName = "msuh2",
                Description = "horoshi2"
            },
            new Model
            {
                Name = "Mus3h",
                Manufacturer = "OtMsuh3",
                Color = "blu3e",
                ApplianceName = "msuh3",
                Description = "horoshiy3"
            }
        };

        [HttpGet]
        public IEnumerable<Model> Get()
        {
            return _models.ToArray();
        }
    }
}
