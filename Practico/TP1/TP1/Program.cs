using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    /* Solicitar al usuario que ingrese la base y altura de un rectángulo, y calcular y mostrar
por pantalla el área y perímetro del mismo */

    internal class Program
    {
        static void Main(string[] args)
        {
            int bas, alt, area, peri;

            Console.WriteLine("Ingrese la base del rectangulo: ");
            bas=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            alt=int.Parse(Console.ReadLine());

            area= bas*alt;
            peri=2*alt+2*area;

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La area del Rectangulo es: " + area);
            Console.WriteLine("El perimetro del Rectangulo es: "+peri);

            Console.ReadLine();

        }
    }
}
