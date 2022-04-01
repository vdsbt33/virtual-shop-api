using Microsoft.AspNetCore.Mvc;

namespace VirtualShop.API.Controller
{
    [ApiController, Route("[controller]")]
    public class HealthcheckController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetHealthcheck()
        {
            return Ok($"API is running. Local time: \'{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}\'.");
        }
    }
}