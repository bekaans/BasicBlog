using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {


        ICategoryDAL _icategorydal;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _icategorydal = categoryDAL;
        }
        public List<Category> GetList()
        {
            return _icategorydal.List();
        }
        public void CategoryAdd(Category category)
        {
           _icategorydal.Insert(category);
        }

        public Category GetById(int id)
        {
            return _icategorydal.Get(x => x.CategoryID == id);
        }

        public void CategoryRemove(Category category)
        {
            _icategorydal.Delete(category);
        }
    }
}
