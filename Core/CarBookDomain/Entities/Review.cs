using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookDomain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }

        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string CustomerComment { get; set; }
        public string CustomerRaytingValue { get; set; }
        public string ReviewDate { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
