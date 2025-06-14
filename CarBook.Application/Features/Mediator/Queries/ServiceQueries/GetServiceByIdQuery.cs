using CarBook.Application.Features.Mediator.Result.ServiceResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery:IRequest<GetServiceByIdResult>
    {
        public GetServiceByIdQuery(int id)
        {
            Id =id;
        }

        public int Id { get; set; }
    }
}
