using ColegioVRHT.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColegioVRHT.BusinessLogic.Interface;
using AutoMapper;
using ColegioVRHT.Entities;

namespace ColegioVRHT.WebClient.Controllers
{
    public class AlumnoController : Controller
    {
        IPersonBusinessLogic _IPersonBusinessLogic;
        public AlumnoController(IPersonBusinessLogic _IPersonBusinessLogic)
        {
            this._IPersonBusinessLogic = _IPersonBusinessLogic;
        }
        //
        // GET: /Alumno/
        public ActionResult Index()
        {
            if (ModelState.IsValid)
            {
                
            }
            else
            {
                throw new Exception("Exeption Controlada");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AlumnoViewModel model)
        {
            var asda = Mapper.Map<AlumnoViewModel, Person>(model);
            _IPersonBusinessLogic.Add(asda);
            return View(model);
        }
	}
}