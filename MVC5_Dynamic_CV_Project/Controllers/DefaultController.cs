using MVC5_Dynamic_CV_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Dynamic_CV_Project.Controllers
{
    public class DefaultController : Controller
    {
        DbCVEntities db = new DbCVEntities();
        // GET: Default
        public ActionResult Index()
        {
            var values = db.Abouts.ToList();
            return View(values);
        }
    }
}