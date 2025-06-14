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
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _bannerRepository;

        public GetBannerQueryHandler(IRepository<Banner> bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }
        public async Task< List<GetBannerQueryResult>> Handler()
        {
            var values=await _bannerRepository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                BannerId = x.BannerId,
                Description = x.Description,
                Title = x.Title,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();
        }
    }
}
