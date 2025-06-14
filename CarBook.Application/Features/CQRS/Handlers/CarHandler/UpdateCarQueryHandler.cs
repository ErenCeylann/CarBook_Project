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
    public class UpdateCarQueryHandler
    {
        private readonly IRepository<Car> _brandRepository;

        public UpdateCarQueryHandler(IRepository<Car> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(UpdateCarCommand updateCarCommand)
        {
            var values = await _brandRepository.GetByIdAsync(updateCarCommand.CarId);
            values.Transmission=updateCarCommand.Transmission;
            values.BrandId=updateCarCommand.BrandId;
            values.CarId=updateCarCommand.CarId;
            values.BigImageUrl=updateCarCommand.BigImageUrl;
            values.CoverImageUrl=updateCarCommand.CoverImageUrl;
            values.Km=updateCarCommand.Km;
            values.Fuel=updateCarCommand.Fuel;
            values.Model=updateCarCommand.Model;
            values.Luggage=updateCarCommand.Luggage;
            await _brandRepository.UpdateAsync(values);
        }
    }
}
