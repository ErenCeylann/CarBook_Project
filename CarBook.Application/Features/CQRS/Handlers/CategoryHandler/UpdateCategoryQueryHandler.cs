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
    public class UpdateCategoryQueryHandler
    {
        private readonly IRepository<Category> _CategoryRepository;

        public UpdateCategoryQueryHandler(IRepository<Category> CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var values = await _CategoryRepository.GetByIdAsync(command.CategoryId);
            values.CategoryId = command.CategoryId;
            values.Name = command.Name;
            await _CategoryRepository.UpdateAsync(values);
        }
    }
}
