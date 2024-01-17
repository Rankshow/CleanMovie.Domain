using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.Api.Controllers
{
    [Route("api/rentals")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _service;
        public RentalController(IRentalService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Rental>> GetAllRental() 
        {
            var fromService = _service.GetAllRental();
            return Ok(fromService);    
        }

        [HttpPost]
        public ActionResult<Rental> PostRental(Rental rental) 
        {
            var addRental = _service.CreateRental(rental);
            return Ok(addRental);   
        }
    }
}
