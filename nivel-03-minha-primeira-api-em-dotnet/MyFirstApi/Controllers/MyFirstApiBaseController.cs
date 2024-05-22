using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyFirstApiBaseController : ControllerBase
    {
        public string Author { get; set; } = "Reinan Guilherme";

        [HttpGet("healthy")]
        public IActionResult Healthy()
        {
            return Ok("Server On");
        }

        protected string GetCustomKey()
        {
            return Request.Headers["MyKey"].ToString();
        }
    }
}
