using CarBook.Application.Features.Mediator.Queries.ReviewQueries;
using CarBook.Application.Features.Mediator.Result.CarPricing;
using CarBook.Application.Features.Mediator.Result.ReviewResults;
using CarBook.Application.Interfaces.CarPricengInterfaces;
using CarBook.Application.Interfaces.ReviewInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.ReviewHandlers
{
    public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdResult>>
    {
        private readonly IReviewRepository _repository;

        public GetReviewByCarIdQueryHandler(IReviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReviewByCarIdResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetReviewByCarId(request.Id);
            return values.Select(x => new GetReviewByCarIdResult
            {
                CarId = x.CarId,
                CustomerComment = x.CustomerComment,
                CustomerImage = x.CustomerImage,
                CustomerName = x.CustomerName,
                CustomerRaytingValue = x.CustomerRaytingValue,
                ReviewDate=x.ReviewDate,
                ReviewId=x.ReviewId,
                
            }).ToList();
        }
    }
}
