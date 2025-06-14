using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _brandRepository;

        public CreateCategoryCommandHandler(IRepository<Category> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(CreateCategoryCommand createCategory)
        {
            await _brandRepository.CreateAsync(new Category
            {
                Name = createCategory.Name,
            });
        }
    }
}
