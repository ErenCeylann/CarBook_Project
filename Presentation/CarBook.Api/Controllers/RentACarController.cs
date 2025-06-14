using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentACarByLocation(int locationId, bool available)
        {
            GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
            {
                Available = available,
                LocationId = locationId

            };
            var values=await _mediator.Send(getRentACarQuery);
            return Ok(values);
        }
    }
}
