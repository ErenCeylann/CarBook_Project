using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
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
    public class GetCarCountByFuelGasolinaOrDiselQueryHandler: IRequestHandler<GetCarCountByFuelGasolinaOrDiselQuery, GetCarCountByFuelGasolinaOrDiselQueryResult>
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public GetCarCountByFuelGasolinaOrDiselQueryHandler(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task<GetCarCountByFuelGasolinaOrDiselQueryResult> Handle(GetCarCountByFuelGasolinaOrDiselQuery request, CancellationToken cancellationToken)
        {
            var values = _statisticsRepository.GetCarCountByFuelGasolinaOrDisel();
            return new GetCarCountByFuelGasolinaOrDiselQueryResult
            {
                CarCountByFuelGasolinaOrDisel = values
            };
        }
    }
}
