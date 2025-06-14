using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.CommentsHandler
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommands>
    {
        private readonly IRepository<Comment> _repository;

        public CreateCommentHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        
            
        public async Task Handle(CreateCommentCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
                BlogId = request.BlogId,
                CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Description = request.Description,
                Name = request.Name,
                Mail= request.Mail,
            });
        }
    }
}
