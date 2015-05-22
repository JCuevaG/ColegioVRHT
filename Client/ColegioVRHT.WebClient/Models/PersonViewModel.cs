using ColegioVRHT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ColegioVRHT.WebClient.Models
{
    public class PersonViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        [StringLength(50, ErrorMessage = "The input is Max Legth 50")]
        public string Names { get; set; }

        [DisplayName("Sede")]
        public int IdSede { get; set; }
        public TypeDocument TypeDocument { get; set; }
        public TypePerson TypePerson { get; set; }
        public string Last { get; set; }
        public string Sexo { get; set; }
        public string Document { get; set; }
        public string Direction { get; set; }
    }
}