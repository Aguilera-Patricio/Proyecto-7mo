using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    /* Crear un programa que solicite al usuario que ingrese el precio de un producto al
inicio del año, y el precio del mismo producto al finalizar el año. El programa debe
calcular cuál fue el porcentaje de aumento que tuvo ese producto en el año y
mostrarlo por pantalla. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int pi, pf, por;

            Console.WriteLine("Ingrese el precio del producto al inicio del año: ");
            pi = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto al final del año: ");
            pf = int.Parse(Console.ReadLine());

            por = ((pf+pi)/pi)*10;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El porcentaje de aumento del producto es de: "+por+"%");

            Console.ReadLine();
        }
    }
}
