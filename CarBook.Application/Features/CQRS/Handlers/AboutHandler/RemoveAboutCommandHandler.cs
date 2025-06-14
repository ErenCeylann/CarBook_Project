using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _removeAbout;

        public RemoveAboutCommandHandler(IRepository<About> removeAbout)
        {
            _removeAbout = removeAbout;
        }
        public async Task Handle(RemoveAboutCommand removeAboutCommand)
        {
            var value= await _removeAbout.GetByIdAsync(removeAboutCommand.AboutId);
            await _removeAbout.RemoveAsync(value);
        }
    }
}
