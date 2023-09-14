using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Controllers
{
    public class CvController : Controller
    {
        // GET: Cv
        public FileResult GetCv()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Templates/Cv/" + "Cv.pdf"));
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf);

        }
    }
}