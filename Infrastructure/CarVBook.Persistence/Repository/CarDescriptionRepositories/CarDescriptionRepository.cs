using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        public CarDescription GetCarDescription(int id)
        {
           var values=_context.CarDescriptions.Where(x=>x.CarId == id).FirstOrDefault();
            return values;
        }
    }
}
