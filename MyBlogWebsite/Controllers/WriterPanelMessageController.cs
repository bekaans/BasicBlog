using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDAL());
        MessageValidator messageValidator = new MessageValidator();
        // GET: WriterPanelMessage
        public ActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
        public ActionResult Sendbox()
        {
            var messagelist = mm.GetListSendBox();
            return View(messagelist);
        }
        public ActionResult GetInboxDetails(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }
        public ActionResult GetSendboxDetails(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }
    }
}