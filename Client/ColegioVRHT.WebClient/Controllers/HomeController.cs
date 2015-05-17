using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColegioVRHT.Repository;
using ColegioVRHT.Entities;
namespace ColegioVRHT.WebClient.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ColegioVRHTContext conext = new ColegioVRHTContext();
            var asdas = conext.Alumnos.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}