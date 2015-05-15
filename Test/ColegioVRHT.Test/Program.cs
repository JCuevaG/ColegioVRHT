using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioVRHT.Entities;

namespace ColegioVRHT.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno();
            a1.name = "pulguita";
            a1.last_name = "enanito";
            a1.ToString();
        }
    }
}
