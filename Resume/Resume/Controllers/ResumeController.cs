using Resume.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class ResumeController : Controller
    {
        ResumeContext db = new ResumeContext();
        // GET: Resume
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public ActionResult Post()
        {
            return View(db.Posts.ToList());
        }
    }
}