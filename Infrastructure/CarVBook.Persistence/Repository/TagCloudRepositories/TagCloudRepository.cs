using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;
        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }
        public List<TagCloud> GetTadCloudsByBlogId(int id)
        {
            var value=_context.TagClouds.Where(x=>x.BlogId == id).ToList();
            return value;
        }
    }
}
