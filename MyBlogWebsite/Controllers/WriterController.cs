using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
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
    }
}