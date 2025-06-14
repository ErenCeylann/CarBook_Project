using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetBrandByCarCountHandler
    {
        private readonly ICarRepositories _repositories;

        public GetBrandByCarCountHandler(ICarRepositories repositories)
        {
            _repositories = repositories;
        }
        public async Task<List<GetBranByCarCount>> Handler()
        {
            var values = _repositories.GetGroupBrandByCarCount();
            return values.Select(x => new GetBranByCarCount
            {
                BrandName = x.BrandName,
                CarCount=x.CarCount,
            }).ToList();
        }
    }
}
