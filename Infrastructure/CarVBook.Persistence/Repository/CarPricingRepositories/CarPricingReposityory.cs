using CarBook.Application.Interfaces.CarPricengInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.CarPricingRepositories
{
    public class CarPricingReposityory : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingReposityory(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            var value=_context.CarPricings.Include(x=>x.Car).ThenInclude(y=>y.Brand).ToList();
            return value;
        }

        public List<CarPricing> GetCarsPricingWithCars()
        {
          
            var value = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).ToList();
            return value;
        

    }
}
}
