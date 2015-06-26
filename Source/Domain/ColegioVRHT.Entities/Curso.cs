namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Curso")]
    public partial class Curso
    {
        public Curso()
        {
            HorarioCurso = new HashSet<HorarioCurso>();
            CursoProfesor = new HashSet<CursoProfesor>();
            Nota = new HashSet<Nota>();
        }

        public int Id { get; set; }

        public int IdCiclo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionCorta { get; set; }

        public bool FlagEstado { get; set; }

        public int HorasDictadas { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        public virtual ICollection<HorarioCurso> HorarioCurso { get; set; }

        public virtual Ciclo Ciclo { get; set; }

        public virtual ICollection<CursoProfesor> CursoProfesor { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }
    }
}
