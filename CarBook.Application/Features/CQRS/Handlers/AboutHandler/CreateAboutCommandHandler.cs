using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public CreateAboutCommandHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task Handle(CreateAboutCommand createAboutCommand)
        {
            await _aboutRepository.CreateAsync(new About
            {
                Title = createAboutCommand.Title,
                Description = createAboutCommand.Description,
                ImageUrl = createAboutCommand.ImageUrl
            });
        }
    }
}
