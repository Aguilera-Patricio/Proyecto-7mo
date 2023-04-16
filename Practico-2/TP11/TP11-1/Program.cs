using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    /* Pide al usuario dos números y muestra la “distancia” entre ellos (el valor absoluto de su diferencia, de
modo que el resultado sea siempre positivo). */

    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            int dis;



            Console.WriteLine("Ingrese el primer numero : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero : ");
            num2 = int.Parse(Console.ReadLine());

            dis = Math.Abs(num - num2);


            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("La cantidad de numeros de distancia es de: " + dis);


            Console.ReadKey();
        }
    }
}