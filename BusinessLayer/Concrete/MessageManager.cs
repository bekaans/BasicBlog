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
            return _imessagedal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListSendBox(string sender)
        {
            return _imessagedal.List(x => x.MessageSender == sender);
        }

        public List<Message> GetListInbox(string receiver)
        {
            return _imessagedal.List(x => x.MessageReceiver == receiver);
        }

       
        public void MessageAdd(Message message)
        {
           _imessagedal.Insert(message);
        }

        public void MessageRemove(Message message)
        {
           _imessagedal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
           _imessagedal.Update(message);
        }
    }
}
