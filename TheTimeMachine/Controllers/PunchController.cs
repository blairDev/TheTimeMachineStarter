using Microsoft.AspNetCore.Mvc;
using TheTimeMachine.Data;
using TheTimeMachine.Logic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheTimeMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunchController : ControllerBase
    {
        
        // GET api/<PunchController>/byPunchId/5
        [HttpGet("byPunchId/{Id}")]
        public ActionResult<List<ClockPunch>> GetByPunchId(int Id)
        {
            List<ClockPunch> userPunches = ClockPunches.GetPunchByPunchId(Id);
            return Ok(userPunches);
        }

        // GET api/<PunchController>/byUserId/5
        [HttpGet("byUserId/{Id}")]
        public ActionResult<List<ClockPunch>> GetByUserID(int Id)
        {
            List<ClockPunch> userPunches = ClockPunches.GetPunchesByUserId(Id);
            return Ok(userPunches);
        }

        // GET api/<PunchController>/timeOnClock/5
        [HttpGet("timeOnClock/{Id}")]
        public ActionResult<double> GetByTime(int Id)
        {
            PayPeriod payPeriod = new PayPeriod();
            double TotalTime = payPeriod.CalculateTotalHours(Id);
            return Ok(TotalTime);
        }

        // POST api/<PunchController>
        [HttpPost]
        public ActionResult<ClockPunch> Post([FromBody] ClockPunch clockPunch)
        {
            ClockPunches.AddPunch(clockPunch);
            return Ok(clockPunch);
        }

    }
}
