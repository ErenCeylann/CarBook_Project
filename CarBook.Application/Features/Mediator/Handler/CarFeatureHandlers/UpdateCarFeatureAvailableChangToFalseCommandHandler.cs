using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.CarFeatureHandlers
{
    public class UpdateCarFeatureAvailableChangToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangToFalseCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeatureAvailableChangToFalseCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarFeatureAvailableChangToFalseCommand request, CancellationToken cancellationToken)
        {
           _repository.ChangCarFeatureAvailableToFalse(request.Id);
           
        }
    }
}
