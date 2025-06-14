using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Result.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.BlogHandlers
{
    public class GetLast3BlogWithAuthorHandler : IRequestHandler<GetLast3BlogsWithAuthorQuery, List<GetLast3BlogWithAuthorResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetLast3BlogWithAuthorHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetLast3BlogWithAuthorResult>> Handle(GetLast3BlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _blogRepository.GetLast3BlogWithAuthor();
            return values.Select(x => new GetLast3BlogWithAuthorResult
            {
                AuthorId = x.AuthorId,
                AuthorName=x.Author.Name,
                BlogId=x.BlogId,
                CategoryId=x.CategoryId,
                CoverImageUrl=x.CoverImageUrl,
                CreateDate=x.CreateDate,
                Description=x.Description,
                Title = x.Title
            }).ToList();
        }
    }
}
