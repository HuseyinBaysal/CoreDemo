using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    //IGenericDal interface'i uzerinde tanımlanan ortak methodları Repository'ler üzerinde tek tek tanımlamak yerine sürdürülebilmesi için GenericRepository tanımlanır.
    //Interface üzerinde tanımlanan Where şartı Kullanılacak Repository'e özel kullanılabilmesi için T tipinde bırakılır.
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly CoreDbContext _dbContext;

        public GenericRepository(CoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(T item)
        {
            _dbContext.Remove(item);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            //Tablo bazlı listeleme yapılamadığı için Set'e bağlı T Tipinde Listeleme Yapılır.  
            return _dbContext.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
