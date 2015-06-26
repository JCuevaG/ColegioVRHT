namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Ciclo")]
    public partial class Ciclo
    {
        public Ciclo()
        {
            Aula = new HashSet<Aula>();
            Curso = new HashSet<Curso>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        public bool FlagEstado { get; set; }

        public virtual ICollection<Aula> Aula { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
