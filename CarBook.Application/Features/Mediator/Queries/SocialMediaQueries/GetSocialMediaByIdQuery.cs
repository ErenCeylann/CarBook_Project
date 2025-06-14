using CarBook.Application.Features.Mediator.Result.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery:IRequest<GetSocialMediaByIdResult>
    {
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
