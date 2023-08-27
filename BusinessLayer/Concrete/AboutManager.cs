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
    public class AboutManager : IAboutService
    {
        IAboutDAL _iaboutdal;

        public AboutManager(IAboutDAL iaboutdal)
        {
            _iaboutdal = iaboutdal;
        }

        public void AboutAdd(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutRemove(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About about)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
