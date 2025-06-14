using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandler
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _brandRepository;

        public CreateContactCommandHandler(IRepository<Contact> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(CreateContactCommand createContact)
        {
            await _brandRepository.CreateAsync(new Contact
            {
                Email = createContact.Email,
                Message = createContact.Message,
                SendDate = createContact.SendDate,
                Subject = createContact.Subject,
                Name = createContact.Name,
            });
        }
    }
}
