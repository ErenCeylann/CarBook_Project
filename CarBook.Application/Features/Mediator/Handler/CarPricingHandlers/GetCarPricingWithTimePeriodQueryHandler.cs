using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Result.CarPricingResults;
using CarBook.Application.Interfaces.CarPricengInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarPricingWithTimePeriod();
            return value.GroupBy(x=>new { x.CarId, x.Car.Model, BrandName = x.Car.Brand.Name, CoverImage = x.Car.CoverImageUrl }).Select(y=>new GetCarPricingWithTimePeriodQueryResult
            {
                CarId=y.Key.CarId,
                Model=y.Key.Model,
                BrandName=y.Key.BrandName,
                CoverImage=y.Key.CoverImage,
                DailyAmount=y.FirstOrDefault(z=>z.PricingId==3)?.Amoun ?? 0,
                WeeklyAmount = y.FirstOrDefault(p=>p.PricingId == 4)?.Amoun ?? 0,
                MonthlyAmount = y.FirstOrDefault(p=>p.PricingId == 6)?.Amoun ?? 0,
            }).ToList();

        }
    }
}
