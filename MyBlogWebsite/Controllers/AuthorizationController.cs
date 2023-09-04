using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager am = new AdminManager(new EFAdminDAL());
        // GET: Authorization
        public ActionResult Index()
        {
            var adminvalues = am.GetList();
            return View(am);
        }
    }
}