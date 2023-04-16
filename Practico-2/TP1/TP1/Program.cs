using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    /*- Escribir un programa que pregunte al usuario su nombre, y luego lo salude.*/

    class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
        }
    }
}