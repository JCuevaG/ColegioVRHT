namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seguridad.Usuario")]
    public partial class Usuario
    {
        public int Id { get; set; }

        public int IdTipoUsuario { get; set; }

        [Column("Usuario")]
        [Required]
        [StringLength(100)]
        public string Usuario1 { get; set; }

        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
