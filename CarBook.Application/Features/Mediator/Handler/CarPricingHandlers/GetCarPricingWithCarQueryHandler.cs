using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Result.CarPricing;
using CarBook.Application.Interfaces.CarPricengInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = _carPricingRepository.GetCarsPricingWithCars();
            return values.Select(x=> new GetCarPricingWithCarQueryResult
            {
                Amount=x.Amoun,
                Brand=x.Car.Brand.Name,
                CarPricingId=x.CarPricingId,
                CoverImageUrl=x.Car.CoverImageUrl,
                Model=x.Car.Model,
                PricingId=x.PricingId,  
                CarId=x.CarId,
            }).ToList();
        }
    }
}
