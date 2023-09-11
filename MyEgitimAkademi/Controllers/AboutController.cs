using MyEgitimAkademi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Controllers
{
    public class AboutController : Controller
    {
       DbMyPortfolioEntities db=new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblAbout.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAbout()
        { 
            return View(); 
        }

        [HttpPost]
        public ActionResult AddAbout(TblAbout tblAbout) 
        {
            var values=db.TblAbout.Add(tblAbout);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public ActionResult DeleteAbout(int id)
        { 
            var values=db.TblAbout.Find(id);
            db.TblAbout.Remove(values);
                db.SaveChanges() ;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id) 
        {
            var values = db.TblAbout.Find(id);
            return View(values);
        }

        [HttpPost]

        public ActionResult UpdateAbout(TblAbout tblAbout) 
        {
            var values = db.TblAbout.Find(tblAbout.AboutID);
            values.NameSurname = tblAbout.NameSurname;
            values.Introduction = tblAbout.Introduction;
            values.AboutImage = tblAbout.AboutImage;
            values.Description= tblAbout.Description;
            values.Title= tblAbout.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}