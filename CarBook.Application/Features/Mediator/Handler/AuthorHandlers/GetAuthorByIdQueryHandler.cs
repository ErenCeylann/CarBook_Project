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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdResult>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdResult
            {
                Description = values.Description,
                AuthorId = values.AuthorId,
                ImageUrl = values.ImageUrl,
                Name = values.Name
            };
        }
    }
}
