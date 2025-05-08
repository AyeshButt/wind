using Microsoft.AspNetCore.Mvc;

namespace wind.api.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {

        [HttpGet("bull")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
