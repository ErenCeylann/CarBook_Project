using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
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
    public class UpdateReviewHandler:IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public UpdateReviewHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ReviewId);
            values.CarId = request.CarId;
            values.CustomerComment=request.CustomerComment;
            values.CustomerName=request.CustomerName;
            values.CustomerImage=request.CustomerImage;
            values.ReviewId = request.ReviewId;
            values.ReviewDate=request.ReviewDate;
            values.CustomerRaytingValue=request.CustomerRaytingValue;
            await _repository.UpdateAsync(values);
        }
    }
}
