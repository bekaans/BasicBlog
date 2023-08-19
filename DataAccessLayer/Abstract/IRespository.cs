using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRespository<T>
    {
        List<T> List();

        //Crud Operations
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
    }
}
