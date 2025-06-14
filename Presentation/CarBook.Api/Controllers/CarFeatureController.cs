using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeatureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CarFeatureListByCarId(int id)
        {
            var values = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
            return Ok(values);
        }

        [HttpGet("UpdateCarFeatureAvailableChangToFalse")]
        public async Task<IActionResult> UpdateCarFeatureAvailableChangToFalse(int id)
        {
             _mediator.Send(new UpdateCarFeatureAvailableChangToFalseCommand(id));
            return Ok("Güncellendi");
        }

        [HttpGet("UpdateCarFeatureAvailableChangToTrue")]
        public async Task<IActionResult> UpdateCarFeatureAvailableChangToTrue(int id)
        {
            _mediator.Send(new UpdateCarFeatureAvailableChangToTrueCommand(id));
            return Ok("Güncellendi");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarCommand(CreateCarFeatureByCarCommand createCarFeatureByCarCommand)
        {
           await _mediator.Send(createCarFeatureByCarCommand);
            return Ok("Eklendi");
        }

    }
}
