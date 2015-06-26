using ColegioVRHT.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColegioVRHT.BusinessLogic.Interface;
using AutoMapper;
using ColegioVRHT.Entities;
using ColegioVRHT.WebClient.Resources;

namespace ColegioVRHT.WebClient.Controllers
{
    public class AlumnoController : Controller
    {
        public readonly IAlumnoBusinessLogic _IAlumnoBusinessLogic;
        public readonly ISexoBusinessLogic _ISexoBusinessLogic;
        public AlumnoController(IAlumnoBusinessLogic IAlumnoBusinessLogic, 
            ISexoBusinessLogic _ISexoBusinessLogic)
        {
            this._IAlumnoBusinessLogic = IAlumnoBusinessLogic;
            this._ISexoBusinessLogic = _ISexoBusinessLogic;
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
        public ActionResult CreateAlumno()
        {
            AlumnoViewModel viewModel = new AlumnoViewModel();
            viewModel.ListaSexo = new List<SexoViewModel>();
            var model = _ISexoBusinessLogic.GetAll().ToList();
            viewModel.ListaSexo = Mapper.Map<List<SexoViewModel>>(model);
            return PartialView(viewModel);
        }

        
        [HttpPost]
        public ActionResult CreateAlumno(AlumnoViewModel model)
        {
            int Identity = 0;
            String Confirmacion = Messages.RegistroError;

            if (ModelState.IsValid)
            {
               var alumno = Mapper.Map<AlumnoViewModel, Alumno>(model);
               Identity= _IAlumnoBusinessLogic.Add(alumno);

               if (Identity > 0)
               {
                   Confirmacion= Messages.RegistroCorrecto;                   
               }
                
            }

           return Content(Confirmacion);
        }

        [HttpGet]
        public ActionResult ConsultarAlumno()
        {
            List<AlumnoViewModel> model = new List<AlumnoViewModel>();
            var alumno = _IAlumnoBusinessLogic.GetAll().ToList();
            model = Mapper.Map<List<AlumnoViewModel>>(alumno);
                        
            return View(PartialViewConstants.ConsultarAlumno, model);
        }
	}
}