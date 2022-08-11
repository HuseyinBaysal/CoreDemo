using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        MvcBlogDbContext dbContext;
        public void AddBlog(Blog blog)
        {
            dbContext.Add(blog);
            dbContext.SaveChanges();
        }

        public void Delete(Blog item)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            dbContext.Remove(blog);
            dbContext.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            return dbContext.Blogs.ToList();
        }

        public Blog GetBlogById(int id)
        {
            return dbContext.Blogs.Find(id);
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog item)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog item)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            dbContext.Update(blog);
            dbContext.SaveChanges();
        }
    }
}
