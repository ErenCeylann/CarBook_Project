using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.ReviewHandlers
{
    public class CreateReviewHandler:IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public CreateReviewHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Review
            {
               CustomerComment = request.CustomerComment,
               CarId = request.CarId,
               CustomerImage = request.CustomerImage,
               CustomerName = request.CustomerName,
               CustomerRaytingValue = request.CustomerRaytingValue,
               ReviewDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString(),
            });
        }
    }
}
