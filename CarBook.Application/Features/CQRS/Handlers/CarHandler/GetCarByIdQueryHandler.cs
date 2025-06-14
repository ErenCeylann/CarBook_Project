using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.BrandResult;
using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery getCarByIdQuery)
        {
            var values = await _repository.GetByIdAsync(getCarByIdQuery.Id);
            return new GetCarByIdQueryResult
            {
                BigImageUrl = values.BigImageUrl,
                Transmission=values.Transmission,
                Seat=values.Seat,
                BrandId=values.BrandId,
                CarId=values.CarId,
                CoverImageUrl=values.CoverImageUrl,
                Fuel = values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model
            };
        }
    }
}
