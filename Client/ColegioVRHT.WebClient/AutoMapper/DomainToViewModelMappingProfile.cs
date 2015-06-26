using AutoMapper;
using ColegioVRHT.Entities;
using ColegioVRHT.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColegioVRHT.WebClient.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AlumnoViewModel, Alumno>();
            Mapper.CreateMap<PersonViewModel, Persona>();
            Mapper.CreateMap<SexoViewModel, Sexo>();    
            
        }
        
    }
}