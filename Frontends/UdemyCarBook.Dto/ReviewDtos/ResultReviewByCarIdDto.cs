using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.ReviewDtos
{
    public class ResultReviewByCarIdDto
    {
        public int ReviewId { get; set; }

        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string CustomerComment { get; set; }
        public string CustomerRaytingValue { get; set; }
        public string ReviewDate { get; set; }
        public int CarId { get; set; }
    }
}
