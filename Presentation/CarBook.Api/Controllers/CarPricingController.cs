using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task< IActionResult> CarPricingWithCarList()
        {
            var value= await _mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(value);
        }

        [HttpGet("GetCarPricingWithTimePeriod")]
        public async Task<IActionResult> GetCarPricingWithTimePeriod()
        {
            var value = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
            return Ok(value);
        }
    }
}
