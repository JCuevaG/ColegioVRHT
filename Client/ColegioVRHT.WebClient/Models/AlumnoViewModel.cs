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
        [Required(ErrorMessage="Name Required")]
        [StringLength(50,ErrorMessage="The input is Max Legth 50")]        
        public string Nombres { get; set; }

        [DisplayName("Sede")]
        public int IdSede { get; set; }

        //public TipoDocumento TipoDocumento { get; set; }

        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
    }
}