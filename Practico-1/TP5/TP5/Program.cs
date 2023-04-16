using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    /* Un colegio desea saber qué porcentaje de niños y qué porcentaje de niñas hay en el
curso actual. Diseñar un programa para este propósito. Recuerda que para calcular el
porcentaje puedes hacer una regla de 3 simple. El programa debe solicitar al usuario
que ingrese la cantidad total de niños, y la cantidad total de niñas que hay en el curso. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int ni, na, nt, pn, pna;

            Console.WriteLine("Ingrese el total de niños del curso: ");
            ni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de niñas del curso: ");
            na = int.Parse(Console.ReadLine());

            nt=ni+na;
            pn = (ni * 100) / nt;
            pna = (na * 100) / nt + 1;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El porcentaje de niños del curso son de: "+pn+"%");
            Console.WriteLine("El porcentaje de niñas del curso son de: " + pna + "%");

            Console.ReadKey();
        }
    }
}
