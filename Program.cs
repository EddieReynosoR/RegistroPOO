using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Registro
{
    //Reynoso Rosales Eduardo Guadalupe #21212036
    class Program
    {        
        static void Main(string[] args)
        {
            string name;
            int age;
            string[] asignatures;
            int cant;
            try
            {
                Console.Write("Indica el nombre del alumno: ");
                name = Console.ReadLine();


                Console.Write("Indica su edad: ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Cuantas materias esta cursando? ");
                cant = int.Parse(Console.ReadLine());

                asignatures = new string[cant];

                for (int i = 0; i < asignatures.Length; i++)
                {
                    Console.Write("Indica su materia #" + (i + 1) + " : ");
                    asignatures[i] = Console.ReadLine();
                }

                Alumno estudiante = new Alumno(name, age, asignatures);

                estudiante.Registro();
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor ingresado incorrecto!!!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Valor invalido...");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }


        }
    }
}
