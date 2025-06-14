using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResult;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler
{
    
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _Repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _Repository = repository;
        }

        public async Task< GetAboutByIdQueryResult> Handle(GetAboutByIdQuery getAboutByIdQuery)
        {
            var values = await _Repository.GetByIdAsync(getAboutByIdQuery.Id);
            return new GetAboutByIdQueryResult
            {
                AboutId = values.AboutId,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title,
            };
        }
    }
}
