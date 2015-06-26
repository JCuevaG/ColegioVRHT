namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Aula")]
    public partial class Aula
    {
        public Aula()
        {
            AlumnoAula = new HashSet<AlumnoAula>();
            HorarioCurso = new HashSet<HorarioCurso>();
            Laboratorio = new HashSet<Laboratorio>();
        }

        public int Id { get; set; }

        public int IdCiclo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        public bool FlagEstado { get; set; }

        public virtual ICollection<AlumnoAula> AlumnoAula { get; set; }

        public virtual ICollection<HorarioCurso> HorarioCurso { get; set; }

        public virtual ICollection<Laboratorio> Laboratorio { get; set; }

        public virtual Ciclo Ciclo { get; set; }
    }
}
