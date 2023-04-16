using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    /*Mostrar el área y perímetro de un paralelogramo.*/

    class Program
    {
        static void Main(string[] args)
        {
            int bas;
            int area;
            int perimetro;
            int altura;
            int lado;

            Console.WriteLine("Ingrese la base del Paralelogramo: ");
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del Paralelogramo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los lados del Paralelogramo: ");
            lado = int.Parse(Console.ReadLine());


            perimetro = (2 * bas) + (2 * lado);
            area = bas * altura;

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La area del  Paralelogramo es : " + area);
            Console.WriteLine("El perimetro del Paralelogramo es: " + perimetro);
            Console.ReadKey();

        }
    }
}

