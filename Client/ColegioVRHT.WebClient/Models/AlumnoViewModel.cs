
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ColegioVRHT.WebClient.Models
{
    public class AlumnoViewModel
    {
        [Display(Name="Name")]
        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Display(Name="Last")]
        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Display(Name="Apoderado")]
        [Required]
        [StringLength(250)]
        public string NombreApoderado { get; set; }

        [Display(Name="Code")]
        [Required]
        [StringLength(25)]
        public string Codigo { get; set; }

        [Display(Name="DNI")]
        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        [Display(Name="Age")]
        public int Edad { get; set; }

        [Display(Name="Birthday")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name="Personal Email")]
        [StringLength(250)]
        public string CorreoPersonal { get; set; }

        [Display(Name="Corporate email")]
        [StringLength(250)]
        public string CorreoCorporativo { get; set; }

        [Display(Name="Phone")]
        [Required]
        [StringLength(9)]
        public string Telefono { get; set; }
        
        [Display(Name="Cell Phone")]
        [Required]
        [StringLength(9)]
        public string Celular { get; set; }

        [Display(Name="Date of egress")]
        public DateTime? FechaEgreso { get; set; }

        [Display(Name="Estado")]
        public bool FlagEstado { get; set; }

        public int IdSexo { get; set; }

        //public virtual ICollection<AlumnoAula> AlumnoAula { get; set; }

        //public virtual ICollection<Nota> Nota { get; set; }

        [Display(Name="Sexo")]
        public virtual SexoViewModel SexoViewModel { get; set; }
        public virtual IEnumerable<SexoViewModel> ListaSexo { get; set; }
        

    }
}