using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Result.CarDescriptionResult
{
    public class GetCarDescriptionQueryResult
    {
        public int CarDescriptionId { get; set; }
        public string Details { get; set; }
        public int CarId { get; set; }
    }
}
