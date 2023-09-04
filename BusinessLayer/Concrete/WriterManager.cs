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
    public class WriterManager : IWriterService
    {
        IWriterDAL _iwriterDAL;

        public WriterManager(IWriterDAL iwriterDAL)
        {
            _iwriterDAL = iwriterDAL;
        }

       
        public Writer GetByID(int id)
        {
            return _iwriterDAL.Get(x => x.WriterID==id);
        }

        public List<Writer> GetList()
        {
            return _iwriterDAL.List();
        }

        public void WriterAdd(Writer writer)
        {
           _iwriterDAL.Insert(writer);
        }

        public void WriterRemove(Writer writer)
        {
           _iwriterDAL.Delete(writer);
        }

      

        public void WriterUpdate(Writer writer)
        {
            _iwriterDAL.Update(writer);
        }

      
    }
}
