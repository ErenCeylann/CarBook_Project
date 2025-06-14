using CarBook.Application.Features.Mediator.Result.CarDescriptionResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionGetByCarIdQuery:IRequest<GetCarDescriptionQueryResult>
    {
        public int Id { get; set; }

        public GetCarDescriptionGetByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}
