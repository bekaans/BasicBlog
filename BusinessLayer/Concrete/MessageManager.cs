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
    public class MessageManager : IMessageService
    {
        IMessageDAL _imessagedal;

        public MessageManager(IMessageDAL imessagedal)
        {
            _imessagedal = imessagedal;
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public void MessageAdd(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageRemove(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
