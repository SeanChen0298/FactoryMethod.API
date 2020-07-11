using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FactoryMethod.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        //[HttpGet("api/sample")]
        public JsonResult GetSamples()
        {
            return new JsonResult(
                new List<object>()
                {
                    new { id = 1, Name = "Sample 1" },
                    new { id = 2, Name = "Sample 2" }
                });
        }
    }
}
