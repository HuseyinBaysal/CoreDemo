using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Tüm Entityler için ortak kullanılan Methodlar tanımlanır.
    //where Şartı ile T bir class olmak zorunda olduğu belirtilir.
    public interface IGenericDal<T> where T:class
    {
        //Ortak Ekleme
        void Insert(T item);
        //Ortak Silme
        void Delete(T item);
        //Ortak Güncelleme
        void Update(T item);
        //Ortak Listeleme
        List<T> GetListAll();
        //Ortak Id'ye gore Getirme
        T GetById(int id);
    }
}
