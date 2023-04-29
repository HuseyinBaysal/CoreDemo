using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        private readonly CoreDbContext _dbContext;

        public BlogRepository(CoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBlog(Blog blog)
        {
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            _dbContext.Blogs.Remove(blog);
            _dbContext.SaveChanges();
        }
        public void UpdateBlog(Blog blog)
        {
            _dbContext.Blogs.Update(blog);
            _dbContext.SaveChanges();
        }

        public List<Blog> GetById(int id)
        {
            return _dbContext.Blogs.Find(id);
        }
        
        public List<Blog> ListAllBlog()
        {
            return _dbContext.Blogs.ToList();
        }
    }
}
