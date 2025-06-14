using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResult
{
    public class GetBranByCarCount
    {
        public string BrandName { get; set; }
        public int CarCount { get; set; }
    }
}
