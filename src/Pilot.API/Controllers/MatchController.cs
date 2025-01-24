using Microsoft.AspNetCore.Mvc;

namespace Pilot.API.Controllers
{
    public class MatchController : ApiController
    {
        [HttpGet]
        public IActionResult CreateMatch()
        {
            return Ok();
        }
    }
}
