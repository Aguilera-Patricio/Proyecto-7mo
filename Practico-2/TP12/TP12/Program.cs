using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12
{
    /* Realizar un programa que lea un número y que muestre su raíz cuadrada y su raíz cúbica. C# tiene
función que permita calcular la raíz cuadrada cúbica. ¿Cómo se puede calcular? */
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double raiz2;
            double raiz3;



            Console.WriteLine("Ingrese el numero : ");
            num = int.Parse(Console.ReadLine());


            raiz2 = Math.Sqrt(num);

            raiz3 = Math.Pow(num, 0.333333333333);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La raiz cuadrada del numero es : " + raiz2);
            Console.WriteLine("La raiz cubica del numero es: " + raiz3);


            Console.ReadKey();
        }
    }
}
