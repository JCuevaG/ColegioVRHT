namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admision.AlumnoAula")]
    public partial class AlumnoAula
    {
        public int Id { get; set; }

        public int IdAula { get; set; }

        public int IdAlumno { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Aula Aula { get; set; }
    }
}
