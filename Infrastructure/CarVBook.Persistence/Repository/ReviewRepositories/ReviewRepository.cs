using CarBook.Application.Interfaces.ReviewInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.ReviewRepositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly CarBookContext _context;

        public ReviewRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Review> GetReviewByCarId(int carId)
        {
            var values = _context.Reviews.Where(x => x.CarId == carId).ToList();
            return values;
        }
    }
}
