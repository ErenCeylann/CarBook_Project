﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarPricingDto
{
    public class ResultCarPricingWithCarDto
    {
        public int CarPricingId { get; set; }
        public int PricingId { get; set; }
        public int CarId { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public string Brand { get; set; }
        public decimal Amount { get; set; }
        
    }
}
