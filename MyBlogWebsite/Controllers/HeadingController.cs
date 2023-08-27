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
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EFHeadingDAL());
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        WriterManager wm = new WriterManager(new EFWriterDAL());
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        { List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString(),
                                                }
                                                 ).ToList();
            ViewBag.vlc = valuecategory;
            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName,
                                                    Value = x.WriterID.ToString(),
                                                }
                                                ).ToList();
            ViewBag.vlc = valuewriter;

            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),
                                                  }
                                                ).ToList();
            ViewBag.vlc = valuecategory;
            var headingvalue = hm.GetById(id);
            return View(headingvalue);
        }
        [HttpPost]
        public ActionResult UpdateHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteHeading(int id) 
        {   
            var headingvalue=hm.GetById(id);
            headingvalue.HeadingStatus = false;
            hm.HeadingRemove(headingvalue);
            return RedirectToAction("Index");
           
        }
       
    }
}