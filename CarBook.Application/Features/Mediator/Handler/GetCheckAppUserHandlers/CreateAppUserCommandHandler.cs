﻿using CarBook.Application.Enums;
using CarBook.Application.Features.Mediator.Commands.RegisterCommands;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.AppUserInterfaces;
using CarBookDomain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handler.GetCheckAppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {

        private readonly IRepository<AppUser> _repository;

        public CreateAppUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser()
            {
                Password = request.Password,
                UserName = request.UserName,
                AppRoleId=(int)RolesType.Member,
                Mail=request.Mail,
                Name=request.Name,
                Surname=request.Surname,
            });
        }
    }
}
