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

        public PartialViewResult Experience()
        {
            var experiences = db.Experiences.ToList();
            return PartialView(experiences);
        }
        public PartialViewResult Education()
        {
            var educations = db.Educations.ToList();
            return PartialView(educations);
        }
        public PartialViewResult Skill()
        {
            var skills = db.Skills.ToList();
            return PartialView(skills);
        }
        public PartialViewResult Hobbie()
        {
            var hobbies = db.Hobbies.ToList();
            return PartialView(hobbies);
        }
        public PartialViewResult Certifica()
        {
            var certificas = db.Certificas.ToList();
            return PartialView(certificas);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(Contacts c)
        {
            c.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (ModelState.IsValid)
            {
                db.Contacts.Add(c);
                db.SaveChanges();
                ViewBag.ResultMessage = "Mesaınız alınmıştır!";
            }            
            return PartialView();
        }
    }
}