using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetLast5CarsWithBrandHandler
    {
        private readonly ICarRepositories _carRepositories;

        public GetLast5CarsWithBrandHandler(ICarRepositories carRepositories)
        {
            _carRepositories = carRepositories;
        }

        public List<GetLast5CarsWithBrandsResult> Handler()
        {
            var values=_carRepositories.GetLast5CarsWithBrand();
            return values.Select(x=> new GetLast5CarsWithBrandsResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,
                BrandName=x.Brand.Name,
                CarId=x.CarId,
                CoverImageUrl=x.CoverImageUrl,
                Fuel=x.Fuel,
                Km=x.Km,
                Luggage=x.Luggage,
                Model=x.Model,
                Seat=x.Seat,
                Transmission=x.Transmission,
            }).ToList();
        }
    }
}
