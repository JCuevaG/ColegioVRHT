using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColegioVRHT.Entities
{
    [Table("Alumno", Schema="Admision")]
    public class Alumno : EntityBase
    {
     
        public string Nombres { get ; set; }
        public int IdSede { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string NombreCompentos()
        {
            return string.Format("{0} ,{1}", Apellidos, Nombres);
        }
       
    }


   
}
