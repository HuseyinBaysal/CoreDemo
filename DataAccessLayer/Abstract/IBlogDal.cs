using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Blog
    public interface IBlogDal
    {
        //Blogların Tamamını Getirme Methodu
        List<Blog> ListAllBlog();
        //Blog Ekleme Methodu
        void AddBlog(Blog blog);
        //Blog Silme Methodu
        void DeleteBlog(Blog blog);

        //Blog Update Methodu
        void UpdateBlog(Blog blog);

        //Blogları Id'ye Gore Getirme Methodu
        List<Blog> GetById(int id);
    }
}
