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
    public class HeadingManager : IHeadingService
    {
        IHeadingDAL _iheadingdal;
        public HeadingManager(IHeadingDAL headingDAL)
        {
            _iheadingdal = headingDAL;
        }
        public List<Heading> GetList()
        {
            return _iheadingdal.List();
        }
        public void HeadingAdd(Heading heading)
        {
            _iheadingdal.Insert(heading);
        }

        public Heading GetById(int id)
        {
            return _iheadingdal.Get(x => x.HeadingID == id);
        }

        public void HeadingRemove(Heading heading)
        {
           
            _iheadingdal.Update(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
           _iheadingdal.Update(heading);

        }
    }
}
