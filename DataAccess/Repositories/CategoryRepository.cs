using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        MvcBlogDbContext dbContext;

        public void AddCategory(Category category)
        {
            dbContext.Add(category);
            dbContext.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            dbContext.Remove(category);
            dbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            return dbContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            dbContext.Update(category);
            dbContext.SaveChanges();
        }
    }
}
