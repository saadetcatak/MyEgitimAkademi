using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi.Models;

namespace MyEgitimAkademi.Controllers
{
    public class ServiceController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Service.ToList();
            return View(values);
        }

        public ActionResult AddService()
        {
            return View();
        }
    }
}