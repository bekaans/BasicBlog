using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IIAdminService
    {
        IAdminDAL _iadmindal;

        public AdminManager(IAdminDAL iadmindal)
        {
            _iadmindal = iadmindal;
        }

        public void CategoryAdd(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void CategoryRemove(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetList()
        {
            return _iadmindal.List();
        }
    }
}
