using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    /*Mostrar el área y perímetro de un rombo.*/

    class Program
    {
        static void Main(string[] args)
        {
            
            int d;
            int dm;
            int area;
            int lado;
            int perimetro;

            Console.WriteLine("Ingrese el diametro mayor del Rombo: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el diametro menor del Rombo: ");
            dm = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado del Rombo: ");
            lado = int.Parse(Console.ReadLine());

            area = (d * dm) / 2;
            perimetro = 4 * lado;

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La area del Rombo es : " + area);
            Console.WriteLine("El perimetro del Rombo es: " + perimetro);


            Console.ReadKey();

        }
    }
}
