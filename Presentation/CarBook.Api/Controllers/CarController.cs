using CarBook.Application.Features.CQRS.Commands.CarCommand;

using CarBook.Application.Features.CQRS.Handlers.CarHandler;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.Mediator.Handler.StatisticsHandlers;
using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarController : ControllerBase
    {
        private readonly GetCarQueryHandler _handler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarQueryHandler _updateCarCommandHandler;
        private readonly RemoveCarQueryHandler _removeCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly GetLast5CarsWithBrandHandler _getLast5CarsWithBrandHandler;
        private readonly GetBrandByCarCountHandler _getBrandByCarCountHandler;


        public CarController(GetCarQueryHandler handler, GetCarByIdQueryHandler getCarByIdQueryHandler, CreateCarCommandHandler createCarCommandHandler, UpdateCarQueryHandler updateCarCommandHandler, RemoveCarQueryHandler removeCarCommandHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetLast5CarsWithBrandHandler getLast5CarsWithBrandHandler, IMediator mediator, GetBrandByCarCountHandler getBrandByCarCountHandler)
        {
            _handler = handler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _getLast5CarsWithBrandHandler = getLast5CarsWithBrandHandler;
            _getBrandByCarCountHandler = getBrandByCarCountHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarList()
        {
            var value = await _handler.Handler();
            return Ok(value);
        }

        [HttpGet("GetLast5CarsWithBrand")]
        public  IActionResult GetLast5CarsWithBrand()
        {
            var value =  _getLast5CarsWithBrandHandler.Handler();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Bilgi güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var value = _getCarWithBrandQueryHandler.Handler();
            return Ok(value);
        }

        [HttpGet("GetBrandByCarCount")]
        public IActionResult GetBrandByCarCount()
        {
            var value=_getBrandByCarCountHandler.Handler();
            return Ok(value);
        }




    }
}
