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

        public List<Message> GetListSendBox()
        {
            return _imessagedal.List(x => x.MessageSender == "admin@gmail.com");
        }

        public List<Message> GetListInbox()
        {
            return _imessagedal.List(x => x.MessageReceiver == "admin@gmail.com");
        }

       
        public void MessageAdd(Message message)
        {
           _imessagedal.Insert(message);
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
