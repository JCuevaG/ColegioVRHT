namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Sexo")]
    public partial class Sexo :EntityBase
    {
        public Sexo()
        {
            Alumno = new HashSet<Alumno>();
            Profesor = new HashSet<Profesor>();
        }

        //public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string DescripcionCorta { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }

        public virtual ICollection<Profesor> Profesor { get; set; }
    }
}
