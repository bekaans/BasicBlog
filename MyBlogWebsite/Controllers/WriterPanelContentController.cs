using BusinessLayer.Concrete;
using DataAccessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EFContentDAL());
        // GET: WriterPanelContent
        public ActionResult MyContent(string p)
        {
            Context c = new Context();
            p = (string)Session["WriterUsername"];
            var writeridinfo=c.Writers.Where(x=>x.WriterUsername==p).Select(y=>y.WriterID).FirstOrDefault();
            var contentvalues = cm.GetListByWriter(writeridinfo);
            return View(contentvalues);
        }
    }
}