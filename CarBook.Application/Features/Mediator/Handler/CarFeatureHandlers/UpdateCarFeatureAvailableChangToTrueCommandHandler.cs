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
    public class UpdateCarFeatureAvailableChangToTrueCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangToTrueCommand>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;

        public UpdateCarFeatureAvailableChangToTrueCommandHandler(ICarFeatureRepository carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task Handle(UpdateCarFeatureAvailableChangToTrueCommand request, CancellationToken cancellationToken)
        {
            _carFeatureRepository.ChangCarFeatureAvailableToTrue(request.Id);
        }
    }
}
