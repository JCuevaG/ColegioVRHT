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
    
    public partial class Docente
    {
        public Docente()
        {
            this.AlumnoDocente = new HashSet<AlumnoDocente>();
        }
    
        public int Id { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
    
        public virtual ICollection<AlumnoDocente> AlumnoDocente { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
