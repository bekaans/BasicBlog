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
    public class WriterLoginManager : IWriterLoginService
    {
        IWriterDAL _iwriterdal;

        public WriterLoginManager(IWriterDAL iwriterdal)
        {
            _iwriterdal = iwriterdal;
        }

        public Writer GetWriter(string username, string password)
        {
            return _iwriterdal.Get(x=>x.WriterUsername==username && x.WriterPassword==password);
        }
    }
}
