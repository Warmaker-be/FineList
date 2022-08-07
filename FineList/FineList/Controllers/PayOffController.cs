using FineList.Models;
using Microsoft.AspNetCore.Mvc;

namespace FineList.Controllers
{
    [ApiController]
    public class PayoffController : ControllerBase
    {
        [HttpPost("/payoff/new")]
        public IActionResult IssueFine(PayOff request)
        {
            return Ok(request);
        }

    }
}
