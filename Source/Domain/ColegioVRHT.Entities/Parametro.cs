namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro.Parametro")]
    public partial class Parametro
    {
        public int Id { get; set; }

        public int IdGrupo { get; set; }

        public virtual Grupo Grupo { get; set; }
    }
}
