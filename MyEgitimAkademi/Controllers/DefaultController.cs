using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi.Models;

namespace MyEgitimAkademi.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialQuickContact()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var value = db.Feature.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialService()
        {
            var value = db.Service.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialSkill()
        {
            var value = db.Skill.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialAward()
        {
            var value = db.Award.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialTestimonial()
        {
            var value = db.Testimonial.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialPartner()
        {
            ViewBag.ProjectCount = db.Project.Count();
            ViewBag.Testimonial = db.Testimonial.Count();
            ViewBag.PartnerCount = db.Partner.Count();
            var values = db.Partner.ToList();
            return PartialView(values);
            
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
    }
}