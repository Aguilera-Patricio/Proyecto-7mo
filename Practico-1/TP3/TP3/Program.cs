using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Program
    {
        /* A partir de una conocida cantidad de días que el usuario ingresa a través del teclado,
escriba un programa para convertir los días en horas, en minutos y en segundos. */

        static void Main(string[] args)
        {
            int dias, h, min, seg;

            Console.WriteLine("Ingrese la cantidad de dias");
            dias = int.Parse(Console.ReadLine());

            h = dias * 24;
            min = dias * 1440;
            seg=dias * 86400;


            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("En horas: " + h);
            Console.WriteLine("En minutos: "+min);
            Console.WriteLine("En segundos: "+seg);

            Console.ReadLine();
        }
    }
}
