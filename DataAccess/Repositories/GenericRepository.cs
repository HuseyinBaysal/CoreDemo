using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        MvcBlogDbContext dbContext = new MvcBlogDbContext();

        public void Delete(T item)
        {
            dbContext.Remove(item);
            dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            dbContext.Add(item);
            dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            dbContext.Update(item);
            dbContext.SaveChanges();
        }
    }
}
