﻿using CarBook.Application.Features.RepositoryPattern;
using CarBook.Persistence.Context;
using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x=>new Comment{
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Name = x.Name,
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x=>x.BlogId == id).ToList();
        }

        public void Remove(Comment entity)
        {
            var value = _context.Comments.Find(entity.CommentId);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public void update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }

        public int GetCountCommentByBlog(int id)
        {
            return _context.Comments.Where(x=>x.BlogId == id).Count();
        }
    }
}
