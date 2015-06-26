using AutoMapper;
using ColegioVRHT.BusinessLogic.Interface;
using ColegioVRHT.Entities;
using ColegioVRHT.WebClient.Models;
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

        public readonly IPersonBusinessLogic _IPersonBusinessLogic;
        public readonly ITypePersonBusinessLogic _ITypePersonBusinessLogic;
        //public readonly ISedeBusinessLogic _ISedeBusinessLogic;


        public PersonController(IPersonBusinessLogic _IPersonBusinessLogic,
                                ITypePersonBusinessLogic _ITypePersonBusinessLogic
                     )
        {
            this._IPersonBusinessLogic = _IPersonBusinessLogic;
            this._ITypePersonBusinessLogic = _ITypePersonBusinessLogic;
            
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ConsultPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConsultPerson(PersonViewModel model)
        {
            var person = Mapper.Map<PersonViewModel, Persona>(model);
            
            _IPersonBusinessLogic.Add(person);
            return View(model);
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
            PersonViewModel PersonViewModel = new PersonViewModel();
            //PersonViewModel.TypePerson = new TypePerson();
            //PersonViewModel.ListTypePerson = _ITypePersonBusinessLogic.GetAll().ToList();
            //PersonViewModel.ListSede = _ISedeBusinessLogic.GetAll().ToList();
            return View(PersonViewModel);
        }

        [HttpPost]
        public JsonResult CreatePerson(PersonViewModel model)
        {
            //Person person = Mapper.Map<PersonViewModel, Person>(model);
            
            //_IPersonBusinessLogic.Add(person);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }



	}
}