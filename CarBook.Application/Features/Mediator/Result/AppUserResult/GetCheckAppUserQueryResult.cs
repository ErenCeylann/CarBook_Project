﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Result.AppUserResult
{
    public class GetCheckAppUserQueryResult
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public bool IsExist { get; set; }
    }
}
