﻿using CarBook.Application.Features.Mediator.Result.LocationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<GetLocationResult>>
    {
    }
}
