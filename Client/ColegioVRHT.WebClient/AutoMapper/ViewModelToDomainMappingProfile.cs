using AutoMapper;
using ColegioVRHT.Entities;
using ColegioVRHT.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColegioVRHT.WebClient.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Alumno, AlumnoViewModel>();
            Mapper.CreateMap<Persona, PersonViewModel>();
            Mapper.CreateMap<Sexo, SexoViewModel>();
        }
    }
}