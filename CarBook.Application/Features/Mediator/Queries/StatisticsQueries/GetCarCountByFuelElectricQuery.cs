using CarBook.Application.Features.Mediator.Result.StatisticsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByFuelElectricQuery:IRequest<GetCarCountByFuelElectricQueryResult>
    {
    }
}
