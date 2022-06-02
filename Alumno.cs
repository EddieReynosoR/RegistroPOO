using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Registro
{
    //Clase alumno
    class Alumno
    {
        //Atributos
        private string nombre;
        private int edad;
        private string[] materias;

        //Constructor
        public Alumno(string aNombre, int aEdad, string[] aMaterias)
        {
            nombre = aNombre;
            edad = aEdad;
            materias = aMaterias;
        }        

        //Metodo de la clase Alumno
        public void Registro()
        {
            
            
            StreamWriter sw = new StreamWriter("alumnos.txt",true);

            /*sw.WriteLine("Nombre \t Edad \t Materias");*/

            sw.Write("\n"+nombre + "\t " + edad + "\t");
            foreach(string lines in materias)
            {
                sw.Write(lines+" || ");
            }

            

            Console.WriteLine("Se añadieron los datos al archivo.");
            sw.Close();
            Console.ReadKey();
        }

        ~Alumno()
        {
            Console.WriteLine("Memoria Liberada Clase Alumno");
        }
    }
}
