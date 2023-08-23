using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using EntityLayer.Conctrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using System.Security.Cryptography.X509Certificates;

namespace MyBlogWebsite.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDAL());
        // GET: Writer
        public ActionResult Index()
        {
            var writervalues = wm.GetList();
            return View(writervalues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p) 
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
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
        [HttpGet]
        public ActionResult UpdateWriter(int id) 
        {
            var writervalue = wm.GetByID(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult UpdateWriter(Writer p)
        {
            wm.WriterUpdate(p);
            return RedirectToAction("Index");

        }
    }
}