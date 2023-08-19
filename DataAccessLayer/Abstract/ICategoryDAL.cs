using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDAL
    {
        List<Category> List();

        //Crud Operations
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);
    }
}
