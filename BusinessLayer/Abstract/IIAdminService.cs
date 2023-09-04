using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIAdminService
    {
        List<Admin> GetList();
        void CategoryAdd(Admin admin);
        Category GetById(int id);
        void CategoryRemove(Admin admin);
        void CategoryUpdate(Admin admin);
    }
}
