﻿using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using CarBook.Application.Features.CQRS.Results.CategoryResult;
using CarBook.Application.Features.Mediator.Queries.FeatureQueries;
using CarBook.Application.Features.Mediator.Result.FeatureResults;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureId = values.FeatureId,
                Name = values.Name,
            };
        }
    }
}
