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
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDAL());
        ContactValidator cv = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contactvalue = cm.GetList();
            return View(contactvalue);
        }
        public ActionResult getContactDetails(int id)
        {
            var contactvalue = cm.GetById(id);
            return View(contactvalue);
        }
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }
    }
}