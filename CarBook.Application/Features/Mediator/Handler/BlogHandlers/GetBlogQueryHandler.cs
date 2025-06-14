using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Result.BlogResults;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handler.BlogHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetBlogResult
            {
               Title = x.Title,
                BlogId = x.BlogId,
                Description = x.Description,
                CreateDate = x.CreateDate,
                CoverImageUrl = x.CoverImageUrl,
                CategoryId = x.CategoryId,
                AuthorId = x.AuthorId
            }).ToList();
        }
    }
}
