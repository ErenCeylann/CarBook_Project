﻿using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Result.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.StatisticsHandlers
{
    public class GetBrandNameByMaxCarQueryHandler: IRequestHandler<GetBrandNameByMaxCarQuery, GetBrandNameByMaxCarQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetBrandNameByMaxCarQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetBrandNameByMaxCarQueryResult> Handle(GetBrandNameByMaxCarQuery request, CancellationToken cancellationToken)
        {
            var values = _statisticsRepository.GetBrandNameByMaxCar();
            return new GetBrandNameByMaxCarQueryResult
            {
                BrandNameByMaxCar = values
            };
        }
    }
}
