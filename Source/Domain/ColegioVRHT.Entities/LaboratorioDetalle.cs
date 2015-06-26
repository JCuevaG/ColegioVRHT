namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.LaboratorioDetalle")]
    public partial class LaboratorioDetalle
    {
        public int Id { get; set; }

        public int IdLaboratorio { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
    }
}
