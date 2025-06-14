using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using CarBook.Application.Features.Mediator.Result.RentACarResults;
using CarBook.Application.Interfaces.RentACarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.RentACarHandler
{
    public class RentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarResult>>
    {
        private readonly IRentACarRepository _repository;

        public RentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetByFilterAsync(x=>x.LocationId==request.LocationId&&x.Avaiable==true);
            return values.Select(x => new GetRentACarResult
            {
                CarId = x.CarId,
                Brand=x.Car.Brand.Name,
                Model=x.Car.Model,
                CoverImageUrl=x.Car.CoverImageUrl,
            }).ToList();
        }
    }
}
