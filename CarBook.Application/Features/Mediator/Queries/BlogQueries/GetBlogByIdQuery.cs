using CarBook.Application.Features.Mediator.Result.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery:IRequest<GetBlogByIdResult>
    {
        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
