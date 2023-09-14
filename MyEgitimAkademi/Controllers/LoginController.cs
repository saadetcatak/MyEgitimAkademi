using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyEgitimAkademi.Models;

namespace MyEgitimAkademi.Controllers
{
    public class LoginController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = db.Admin.FirstOrDefault(x => x.NameSurname == admin.NameSurname && x.Password == admin.Password);
            if(values!=null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["username"] = values.Username.ToString();
                return RedirectToAction("Index", "Service");
            }
            return View();
        }
    }
}