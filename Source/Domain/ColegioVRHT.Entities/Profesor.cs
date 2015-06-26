namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admision.Profesor")]
    public partial class Profesor
    {
        public int Id { get; set; }

        public int IdEspecialidad { get; set; }

        public int IdCargo { get; set; }

        [Required]
        [StringLength(22)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int AñosExperiencia { get; set; }

        [StringLength(250)]
        public string CorreoPersonal { get; set; }

        [StringLength(250)]
        public string CorreoCorporativo { get; set; }

        public DateTime FechaEgreso { get; set; }

        [Required]
        [StringLength(250)]
        public string InstitucionEgresado { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(9)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(9)]
        public string Celular { get; set; }

        public bool FlagEstado { get; set; }

        public int IdSexo { get; set; }

        public virtual Cargo Cargo { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        public virtual Sexo Sexo { get; set; }
    }
}
