using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandler
{
    public class UpdateBrandQueryHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public UpdateBrandQueryHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(UpdateBrandCommand command)
        {
            var values=await _brandRepository.GetByIdAsync(command.BrandId);
            values.BrandId = command.BrandId;
            values.Name = command.Name;
            await _brandRepository.UpdateAsync(values);
        }
    }
}
