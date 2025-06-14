using CarBook.Application.Features.Mediator.Result.RentACarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarQuery:IRequest<List<GetRentACarResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }
    }
}
