using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    /*Hacer un programa que ingrese por teclado un número total de segundos y que luego pueda mostrar la
    cantidad de horas, minutos y segundos que existen en el valor ingresado.*/


    class Program
    {
        static void Main(string[] args)
        {
            int seg;
            int min;
            int h;

            Console.WriteLine("Ingrese una cantidad de segundos: ");
            seg = int.Parse(Console.ReadLine());
            min = seg / 60;
            h = seg / 3600;

            Console.WriteLine("La cantidad de minutos es: " + min );
            Console.WriteLine("La cantidad de las horas son: " + h);
            Console.ReadKey();

        }
    }
}