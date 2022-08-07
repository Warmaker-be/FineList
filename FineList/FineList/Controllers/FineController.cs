using FineList.APIContracts;
using FineList.Models;
using Microsoft.AspNetCore.Mvc;

namespace FineList.Controllers
{
    [ApiController]
    [Route("fines")]
    public class FineController : ControllerBase
    {

        [HttpPost("/issuefine")]
        public IActionResult IssueFine(FineIssuedRequest request)
        {
            return Ok(request);
        }

        [HttpGet]
        public IActionResult GetFines()
        {
            var listOfFines = new List<Fine>() ;
            return Ok(listOfFines);
        }

        [HttpPost("/addfine")]
        public IActionResult AddFine(Fine fine)
        {
            return Ok(fine);
        }

        [HttpDelete]

    }
}
