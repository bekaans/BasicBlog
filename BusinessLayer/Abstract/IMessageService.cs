using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string receiver);
        List<Message> GetListSendBox(string sender);
        void MessageAdd(Message message);
        Message GetById(int id);
        void MessageRemove(Message message);
        void MessageUpdate(Message message);
    }
}
