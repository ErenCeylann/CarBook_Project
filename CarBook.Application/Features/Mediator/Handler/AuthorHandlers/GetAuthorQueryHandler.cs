using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Features.Mediator.Result.AuhorResults;
using CarBook.Application.Features.Mediator.Result.TestimonialResults;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.AuthorHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorResult>>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetAuthorResult
            {
                Name = x.Name,
                AuthorId = x.AuthorId,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
