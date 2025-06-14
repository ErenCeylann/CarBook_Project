using CarBook.Application.Features.CQRS.Commands.BannerCommands;
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
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public CreateBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(CreateBrandCommand createBrand)
        {
            await _brandRepository.CreateAsync(new Brand
            {
                Name = createBrand.Name,
            });
        }
    }
}
