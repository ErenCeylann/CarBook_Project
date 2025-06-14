using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int aboutId)
        {
            AboutId = aboutId;
        }

        public int AboutId { get; set; }
    }
}
