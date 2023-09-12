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
            return PartialView();
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
            return PartialView();
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
    }
}