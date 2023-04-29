using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Category
    public interface ICategoryDal
    {
        //Categorylerin Tamamını Getirme Methodu

        List<Category> ListAllCategory();

        //Category Ekleme Methodu
        void AddCategory(Category category);
        //Category Silme Methodu
        void DeleteCategory(Category category);

        //Category Update Methodu
        void UpdateCategory(Category category);

        //Categoryleri Id'ye Gore Getirme Methodu
        List<Category> GetById(int id);

    }
}
