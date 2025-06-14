using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.StatisticsRepositories
{
    
    public class StatisticsRepository:IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            var value = _context.Comments.GroupBy(y => y.BlogId).Select(y => new
            {
                BlogId = y.Key,
                Count = y.Count(),
            }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();

            string blogTitle=_context.Blogs.Where(x=>x.BlogId==value.BlogId).Select(y=>y.Title).FirstOrDefault();
            
            return blogTitle;
        }

        public string GetBrandNameByMaxCar()
        {
            var values = _context.Cars.GroupBy(x => x.BrandId).Select(y => new
            {
                BrandId = y.Key,
                Count = y.Count(),
            }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();
            string brandName=_context.Brands.Where(x=>x.BrandId==values.BrandId).Select(y=>y.Name).FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            var value=_context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            var value = _context.CarPricings.Where(x => x.Pricing.Name == "Günlük").Average(x => x.Amoun);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            var value = _context.CarPricings.Where(x => x.Pricing.Name == "Aylık").Average(x => x.Amoun);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            var value = _context.CarPricings.Where(x => x.Pricing.Name == "Haftalık").Average(x => x.Amoun);
            return value;
        }

        public int GetBlogCount()
        {
            var value= _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value=_context.Brands.Count();
            return (value);
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            var pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.PricingId).FirstOrDefault();
            decimal maxPricingCar = _context.CarPricings.Where(x => x.PricingId == pricingId).Max(y => y.Amoun);
            var values = _context.CarPricings.Where(x => x.PricingId == pricingId && x.Amoun == maxPricingCar).Select(y => y.Car.Brand.Name).FirstOrDefault();
            return values;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            var pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.PricingId).FirstOrDefault();
            decimal maxPricingCar = _context.CarPricings.Where(x => x.PricingId == pricingId).Min(y => y.Amoun);
            var values = _context.CarPricings.Where(x => x.PricingId == pricingId && x.Amoun == maxPricingCar).Select(y => y.Car.Brand.Name).FirstOrDefault();
            return values;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektrik").Count();
            return value;
        }

        public int GetCarCountByFuelGasolinaOrDisel()
        {
            var value=_context.Cars.Where(x=>x.Fuel=="Benzin"||x.Fuel=="Dizel").Count();
            return value;
        }

        public int GetCarCountByKmLessThan1000()
        {
            var values=_context.Cars.Where(x=>x.Km<=1000).Count();
            return values;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value=_context.Cars.Where(x=>x.Transmission=="Otamatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value= _context.Locations.Count();
            return value;
        }
    }
}
