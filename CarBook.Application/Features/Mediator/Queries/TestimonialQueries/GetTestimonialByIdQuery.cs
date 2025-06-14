using CarBook.Application.Features.Mediator.Result.TestimonialResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery:IRequest<GetTestimonialByIdResult>
    {
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
