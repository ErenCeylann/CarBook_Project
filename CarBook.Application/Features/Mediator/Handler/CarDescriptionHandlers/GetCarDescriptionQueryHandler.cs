using CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBook.Application.Features.Mediator.Result.CarDescriptionResult;
using CarBook.Application.Features.Mediator.Result.LocationResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.CarDescriptionHandlers
{
    public class GetCarDescriptionQueryHandler : IRequestHandler<GetCarDescriptionGetByCarIdQuery, GetCarDescriptionQueryResult>
    {
        private readonly ICarDescriptionRepository _repository;

        public GetCarDescriptionQueryHandler(ICarDescriptionRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionGetByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetCarDescription(request.Id);
            return new GetCarDescriptionQueryResult
            {
                CarDescriptionId=values.CarDescriptionId,
                CarId=values.CarId,
                Details=values.Details,
            };
        }
    }
}
