using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP2
{
    /* Escribir un programa que calcule el volumen de un cilindro. Para ello se deberá
solicitar al usuario que ingrese el radio y la altura. Mostrar el resultado por pantalla. */

    internal class Program
    {
        static void Main(string[] args)
        {
            double alt, vol, radio;

            Console.WriteLine("Ingrese el radio del Cilindro: ");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del Cilindro: ");
            alt = int.Parse(Console.ReadLine());

            vol = (Math.PI * (radio * radio) * alt);

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El volumen del Cilindro es de: "+vol);
            Console.WriteLine();

        }
    }
}
