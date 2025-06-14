using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.RentACarRepository
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<RentACar> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values=_context.RentACars.Where(filter).Include(x=>x.Car).ThenInclude(y=>y.Brand).Include(z=>z.Car.CarPricings).ToList();
            return values;
        }
    }
}
