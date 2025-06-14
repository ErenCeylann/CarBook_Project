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
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand updateBanner)
        {
            var values=await _repository.GetByIdAsync(updateBanner.BannerId);
            values.VideoUrl = updateBanner.VideoUrl;
            values.Title = updateBanner.Title;
            values.Description = updateBanner.Description;
            values.BannerId = updateBanner.BannerId;
            values.VideoDescription = updateBanner.VideoDescription;
            await _repository.UpdateAsync(values);
        }
    }
}
