namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Laboratorio")]
    public partial class Laboratorio
    {
        public Laboratorio()
        {
            LaboratorioDetalle = new HashSet<LaboratorioDetalle>();
        }

        public int Id { get; set; }

        public int IdAula { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        public virtual Aula Aula { get; set; }

        public virtual ICollection<LaboratorioDetalle> LaboratorioDetalle { get; set; }
    }
}
