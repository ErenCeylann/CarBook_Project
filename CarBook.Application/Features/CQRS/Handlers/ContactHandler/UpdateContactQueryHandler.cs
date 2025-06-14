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
    public class UpdateContactQueryHandler
    {
        private readonly IRepository<Contact> _ContactRepository;

        public UpdateContactQueryHandler(IRepository<Contact> ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _ContactRepository.GetByIdAsync(command.ContactId);
            values.ContactId = command.ContactId;
            values.Name = command.Name;
            values.Email = command.Email;
            values.Subject = command.Subject;
            values.Message = command.Message;
            values.SendDate = command.SendDate;
            await _ContactRepository.UpdateAsync(values);
        }
    }
}
