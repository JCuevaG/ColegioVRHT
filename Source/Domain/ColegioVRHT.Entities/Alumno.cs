namespace ColegioVRHT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admision.Alumno")]
    public partial class Alumno :EntityBase
    {
        public Alumno()
        {
            AlumnoAula = new HashSet<AlumnoAula>();
            Nota = new HashSet<Nota>();
        }

        //public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreApoderado { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        public int Edad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [StringLength(250)]
        public string CorreoPersonal { get; set; }

        [StringLength(250)]
        public string CorreoCorporativo { get; set; }

        [Required]
        [StringLength(9)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(9)]
        public string Celular { get; set; }

        public DateTime? FechaEgreso { get; set; }

        //public bool FlagEstado { get; set; }

        public int IdSexo { get; set; }

        public virtual ICollection<AlumnoAula> AlumnoAula { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }

        public virtual Sexo Sexo { get; set; }
    }
}
