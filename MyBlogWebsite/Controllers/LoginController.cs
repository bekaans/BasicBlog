using BusinessLayer.Concrete;
using DataAccessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace MyBlogWebsite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        WriterLoginManager writerlogin = new WriterLoginManager(new EFWriterDAL());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminUsername == p.AdminUsername && x.AdminPassword == p.AdminPassword);
            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUsername, false);
                Session["AdminUsername"] = adminuserinfo.AdminUsername;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult WriterLogin() 
        {
            return View();
        }
        [HttpPost]

        public ActionResult WriterLogin(Writer p)
        {
            var writerlogininfo = writerlogin.GetWriter(p.WriterUsername, p.WriterPassword);
            if (writerlogininfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerlogininfo.WriterUsername, false);
                Session["WriterUsername"] = writerlogininfo.WriterUsername;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Headings", "Default");
        }
    }
}