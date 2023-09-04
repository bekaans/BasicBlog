using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        HeadingManager hm = new HeadingManager(new EFHeadingDAL());
        ContentManager cm = new ContentManager(new EFContentDAL());
        // GET: Default
        public PartialViewResult Index()
        {
            var contentlist = cm.GetList();
            return PartialView(contentlist);
        }
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
    }
}