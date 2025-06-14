using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Features.Mediator.Result.LocationResults;
using CarBook.Application.Features.Mediator.Result.TagCloudResult;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler:IRequestHandler<GetTagCloudByIdQuery,GetTagCloudByIdResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIdResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdResult
            {
                BlogId = values.BlogId,
                Title = values.Title,
                TagCloudId = values.TagCloudId,
            };
        }

       
    }
}
