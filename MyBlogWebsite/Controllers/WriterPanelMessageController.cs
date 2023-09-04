using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using FluentValidation.Results;
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
        Context c = new Context();  
        // GET: WriterPanelMessage
        public ActionResult Inbox()
        {
            string receiver = (string)Session["WriterMail"];
            var messagelist = mm.GetListInbox(receiver);
            return View(messagelist);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
        public ActionResult Sendbox()
        {
            string sender = (string)Session["WriterMail"];
            var messagelist = mm.GetListSendBox(sender);
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
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string sender = (string)Session["WriterMail"];
            ValidationResult results = messageValidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageSender = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}