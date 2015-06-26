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
            viewModel.Sexo = new SexoViewModel();
            viewModel.ListaSexo = new List<SexoViewModel>();
            
             var model = _ISexoBusinessLogic.GetAll().ToList();
             viewModel.ListaSexo = Mapper.Map<List<SexoViewModel>>(model);
            
            return PartialView(viewModel);
        }

        
        [HttpPost]
        public ActionResult CreateAlumno(AlumnoViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            
                model.FechaNacimiento = DateTime.Now;

                model.IdSexo = model.Sexo.Id;
                model.Sexo = null;      
                var alumno = Mapper.Map<AlumnoViewModel, Alumno>(model);


                _IAlumnoBusinessLogic.Add(alumno);
                return Content("Registro Correcto!!!");
            //}

            
            //_IPersonBusinessLogic.Add(asda);
            //return Content("Error ");
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