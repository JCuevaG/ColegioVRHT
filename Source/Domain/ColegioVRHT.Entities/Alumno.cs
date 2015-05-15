using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.Entities
{
    public class Alumno : EntityBase
    {
     
        public string name { get ; set; }
        public string last_name { get; set; }

      

        private Profesor _profesor;

        public Profesor profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }
        

        public override string ToString()
        {
            return string.Format("{0} dxgdfgdfgsfdg {1}", name, last_name);
        }

       
    }


   
}
