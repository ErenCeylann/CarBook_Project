using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.BlogRepository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var value=_context.Blogs.Include(x=>x.Author).Include(x=>x.Category).ToList();
            return value;
        }

        public List<Author> GetBlogByAuthorId(int id)
        {
            var value = _context.Blogs.Where(x => x.BlogId == id).Select(x => x.AuthorId).FirstOrDefault();
            var values = _context.Authors.Where(x => x.AuthorId == value).ToList();
            return values;
        }

        public List<Blog> GetLast3BlogWithAuthor()
        {
            var values=_context.Blogs.Include(x=>x.Author).Take(3).OrderByDescending(x=>x.BlogId).ToList();
            return values;
        }
    }
}
