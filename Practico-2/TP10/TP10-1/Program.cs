using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{
    /* Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto
deberá pagar finalmente por su compra. */

    class Program
    {
        static void Main(string[] args)
        {
            int com;
            int descuento;



            Console.WriteLine("Ingrese el total de su compra: ");
            com = int.Parse(Console.ReadLine());


            descuento = (com * 15) / 100;

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El total de pagar con el descuento del 15% es de: " + (com - descuento)+" pesos");


            Console.ReadKey();
        }
    }
}
