using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Result.RentACarResults
{
    public class GetRentACarResult
    {
        public int CarId { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Amoun { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
