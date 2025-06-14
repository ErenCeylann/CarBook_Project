using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Dto.CarDtos;

namespace CarBook.Persistence.Repository.CarRepositories
{
    public class CarRepository : ICarRepositories
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        

        public List<Car> GetCarWithBrand()
        {
            var values=_context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }

        public List<BrandCarCountDto> GetGroupBrandByCarCount()
        {
            var values = _context.Cars.GroupBy(x=>x.Brand.Name).Select(y=>new BrandCarCountDto
            {
                BrandName=y.Key,
                CarCount=y.Count()
            }).ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrand()
        {
            var values=_context.Cars.Include(x=>x.Brand).Take(5).OrderByDescending(x=>x.CarId).ToList();
            return values;
        }
    }
}
