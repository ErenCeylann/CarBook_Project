using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Result.AuhorResults;
using CarBook.Application.Features.Mediator.Result.BlogResults;
using CarBook.Application.Features.Mediator.Result.TestimonialResults;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdResult
            {
                Description = values.Description,
                BlogId = values.BlogId,
                AuthorId = values.AuthorId,
                CategoryId = values.CategoryId,
                CoverImageUrl = values.CoverImageUrl,
                CreateDate = values.CreateDate,
                Title = values.Title
            };
        }
    }
}
