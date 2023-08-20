using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;
using FluentValidation;

namespace MyBlogWebsite.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm= new CategoryManager(new EFCategoryDAL());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
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
            Category category = new Category();
            CategoryValidatior cv = new CategoryValidatior();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAddBL(category);
            }
            return RedirectToAction("GetCategoryList");
        }
    }
}