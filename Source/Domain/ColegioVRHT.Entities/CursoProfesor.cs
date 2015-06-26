namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.CursoProfesor")]
    public partial class CursoProfesor
    {
        [Key]
        public int IdCursoProfesor { get; set; }

        public int IdCurso { get; set; }

        public decimal PrecioHoraCurso { get; set; }

        public int IdProfesor { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
