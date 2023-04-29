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
    //Data Access Layer Interface'den miras alıp, Context işlemlerini gerçekleştirecek.

    public class CategoryRepository : ICategoryDal
    {
        private readonly CoreDbContext _dbContext;

        public CategoryRepository(CoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _dbContext.Remove(category);
            _dbContext.SaveChanges();
        }
        public void UpdateCategory(Category category)
        {
            _dbContext.Update(category);
            _dbContext.SaveChanges();
        }

        public List<Category> GetById(int id)
        {
            return _dbContext.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return _dbContext.Categories.ToList();
        }

        
    }
}
