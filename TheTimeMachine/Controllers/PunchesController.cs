using Microsoft.AspNetCore.Mvc;
using TheTimeMachine.Data;

namespace TheTimeMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunchesController : ControllerBase
    {
        // GET: api/<Punches>
        [HttpGet]
        public ActionResult<List<ClockPunch>> Get()
        {
            return Ok(ClockPunches.AllPunches);
        }

    }
}
