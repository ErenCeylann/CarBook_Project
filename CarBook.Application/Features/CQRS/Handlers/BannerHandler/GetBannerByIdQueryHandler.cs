using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Results.AboutResult;
using CarBook.Application.Features.CQRS.Results.BannerResult;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandler
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _bannerRepository;

        public GetBannerByIdQueryHandler(IRepository<Banner> bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery getBannerById)
        {
            var values=await _bannerRepository.GetByIdAsync(getBannerById.Id);
            return new GetBannerByIdQueryResult
            {
                BannerId = getBannerById.Id,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl,
            };

        }
    }
}
