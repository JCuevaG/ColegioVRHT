//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColegioVRHT.Repository.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlumnoDocente
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdDocente { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Docente Docente { get; set; }
    }
}