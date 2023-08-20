using BusinessLayer.Concrete;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm= new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
           // var categoryvalues = cm.GetAllBusinessLayer();
           // return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBusinessLayer(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}