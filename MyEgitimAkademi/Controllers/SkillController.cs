using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi.Models;

namespace MyEgitimAkademi.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Skill.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult AddSkill()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value=db.Skill.Find(id);
            db.Skill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.Skill.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var values = db.Skill.Find(skill.SkillID);
            values.SkillTitle = skill.SkillTitle;
            values.SkillValue = skill.SkillValue;
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}