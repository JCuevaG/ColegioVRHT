using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.Entities
{
    
    public class Persona : EntityBase
    {
        public string Nombres { get; set; }
        public int IdSede { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
    }
}
