using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarPricengInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarsPricingWithCars();

        List<CarPricing> GetCarPricingWithTimePeriod();
    }
}
