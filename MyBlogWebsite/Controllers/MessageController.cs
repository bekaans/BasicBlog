﻿using BusinessLayer.Concrete;
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
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDAL());
        MessageValidator messageValidator = new MessageValidator();

        // GET: Message
     
        public ActionResult Inbox(string p)
        {
            var messagelist = mm.GetListInbox(p);
            return View(messagelist);
        }
        public ActionResult Sendbox(string p) 
        {
            var messagelist = mm.GetListSendBox(p);
            return View(messagelist);
        }
        [HttpGet]
        public ActionResult NewMessage() 
        { 
                return View();
        }
        [HttpPost]
        public ActionResult NewMessage (Message p)
        {

            ValidationResult results = messageValidator.Validate(p);
            if (results.IsValid)
            {
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