using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandler
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand createBanner)
        {
            await _repository.CreateAsync(new Banner
            {
                Description = createBanner.Description,
                Title = createBanner.Title,
                VideoDescription = createBanner.VideoDescription,
                VideoUrl = createBanner.VideoUrl,
            });
        }
    }
}
