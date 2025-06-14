using CarBook.Application.Features.Mediator.Result.CarPricing;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarQuery:IRequest<List<GetCarPricingWithCarQueryResult>>
    {
    }
}
