using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using CarBook.Application.Features.CQRS.Results.ContactResult;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandler
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery getContactByIdQuery)
        {
            var values = await _repository.GetByIdAsync(getContactByIdQuery.Id);
            return new GetContactByIdQueryResult
            {
                Subject=values.Subject,
                SendDate=values.SendDate,
                Message=values.Message,
                Email=values.Email,
                ContactId = values.ContactId,
                Name = values.Name,
            };
        }
    }
}
