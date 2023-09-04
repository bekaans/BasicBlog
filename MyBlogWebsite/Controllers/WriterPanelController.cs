﻿using BusinessLayer.Concrete;
using DataAccessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
     
    public class WriterPanelController : Controller
    {
       
        HeadingManager hm = new HeadingManager(new EFHeadingDAL());
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        int id;
        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading(string p)
        {   
            Context c = new Context();
            p = (string)Session["WriterUsername"];
           
           var writerheadingvalues = c.Writers.Where(x=>x.WriterUsername==p).Select(y=>y.WriterID).FirstOrDefault();
            var values = hm.GetListByWriter(writerheadingvalues);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            string writeridinfo = (string)Session["WriterUsername"];
            var writerheadingvalues = c.Writers.Where(x => x.WriterUsername == writeridinfo).Select(y => y.WriterID).FirstOrDefault();

            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),
                                                  }
                                                ).ToList();
            ViewBag.vlc = valuecategory;
           
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            ViewBag.d = id;
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = 0;
            p.HeadingStatus = true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
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
            return RedirectToAction("MyHeading");
        }
        public ActionResult DeleteHeading(int id)
        {
            var headingvalue = hm.GetById(id);
            headingvalue.HeadingStatus = false;
            hm.HeadingRemove(headingvalue);
            return RedirectToAction("MyHeading");

        }
    }
}