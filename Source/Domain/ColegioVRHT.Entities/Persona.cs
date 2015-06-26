namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admision.Persona")]
    public partial class Persona : EntityBase
    {
        public Persona()
        {
            //MateriaAlumno = new HashSet<MateriaAlumno>();
        }

        //public int Id { get; set; }

        public int IdTipoDocumento { get; set; }

        public int IdSede { get; set; }

        public int IdTipoPersona { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Required]
        [StringLength(12)]
        public string Documento { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        //public bool FlagEstado { get; set; }

        //public virtual ICollection<MateriaAlumno> MateriaAlumno { get; set; }
    }
}
