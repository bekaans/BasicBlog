using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            ValidationResult results = messageValidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageSender = "eda54";
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