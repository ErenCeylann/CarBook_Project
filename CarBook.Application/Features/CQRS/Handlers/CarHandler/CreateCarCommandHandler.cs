using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommand;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandler
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _brandRepository;

        public CreateCarCommandHandler(IRepository<Car> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(CreateCarCommand createCarCommand)
        {
            await _brandRepository.CreateAsync(new Car
            {
                BigImageUrl = createCarCommand.BigImageUrl,
                CoverImageUrl = createCarCommand.CoverImageUrl,
                Fuel=createCarCommand.Fuel,
                BrandId=createCarCommand.BrandId,
                Km= createCarCommand.Km,
                Transmission= createCarCommand.Transmission,
                Seat=createCarCommand.Seat,
                Model = createCarCommand.Model,
                Luggage=createCarCommand.Luggage,
                

            });
        }
    }
}
