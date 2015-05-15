using ColegioVRHT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> list = new List<Alumno>(){
                new Alumno(){
                name ="enamo",
                id=1,
                profesor =  new Profesor(){
                    cargo="asdas",
                    id=1
                    }
                },
                new Alumno(){
                name ="enamo2",
                id=2,
                 profesor =   new Profesor(){
                    cargo="asdas",
                    id=2
                }
                }, 

                new Alumno(){
                name ="enamo3",
                id=1,
                profesor =  new Profesor(){
                    cargo="asdas",
                    id=1
                    }
                }
              
            };

            List<Profesor> list2 = new List<Profesor>(){
                new Profesor(){
                cargo ="1eraño",
                id=1
                },
                new Profesor(){
                cargo ="2doaño",
                id=2
                }
            };



            
        }
    }
}
