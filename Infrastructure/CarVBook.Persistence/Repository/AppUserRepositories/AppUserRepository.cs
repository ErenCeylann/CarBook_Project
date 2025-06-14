using CarBook.Application.Interfaces.AppUserInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repository.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly CarBookContext _context;

        public AppUserRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            var values =  _context.AppUsers.Where(filter).Include(x=>x.AppRole).FirstOrDefault();
            return values;
        }
    }
}
