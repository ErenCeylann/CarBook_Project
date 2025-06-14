using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.Interfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.ReservationHandler
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;

        public CreateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Reservation
            {
                Age=request.Age,
                Description=request.Description,
                DriveLicenseYear=request.DriveLicenseYear,
                DropOffLocationId=request.DropOffLocationId,
                PickUpLocationId=request.PickUpLocationId,
                CarId=request.CarId,
                Mail = request.Mail,
                Surname=request.Surname,
                Name=request.Name,
                Phone = request.Phone,
                Status=request.Status,

            });
        }
    }
}
