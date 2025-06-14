using CarBook.Application.Features.Mediator.Queries.AppUserQueries;
using CarBook.Application.Features.Mediator.Result.AppUserResult;
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
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IAppUserRepository _repository;

        public GetCheckAppUserQueryHandler(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await _repository.GetByFilterAsync(x=>x.UserName==request.UserName&&x.Password==request.Password);
            if (user==null)
            {
                values.IsExist = false;
            }
            else
            {
                values.IsExist= true;
                values.UserName=user.UserName;
                values.Role= _repository.GetByFilterAsync(x=>x.AppRoleId==user.AppRoleId).Result.AppRole.AppRoleName;
                values.Id = user.AppUserId;
            }
            return values;
        }
    }
}
