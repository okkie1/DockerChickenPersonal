using Microsoft.AspNetCore.Mvc;

namespace ChickenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EggController : ControllerBase
    {
        [HttpGet("/GetMeEggs")]
        public IActionResult GetMeEggs()
        {
            return Ok("Here are your eggs! :");
        }
    }
}