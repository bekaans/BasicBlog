﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogWebsite.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            return View();
        }
    }
}