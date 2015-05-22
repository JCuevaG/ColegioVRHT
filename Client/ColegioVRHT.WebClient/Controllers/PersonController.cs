using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColegioVRHT.WebClient.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Persona/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ConsultarPersona()
        {

            return View();
        }
	}
}