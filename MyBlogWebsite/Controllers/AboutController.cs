using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EFAboutDAL());
        public ActionResult Index()
        {
            var aboutvalue = am.GetList();

            return View(aboutvalue);
        }
        [HttpGet]
        public ActionResult AddAbout() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            am.AboutAdd(p);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
    }
}