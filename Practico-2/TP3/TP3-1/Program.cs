using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /*Hacer un programa que calcule el salario de un empleado, si se descuenta el 20% de su salario bruto.*/

    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float sb;


            Console.WriteLine("Ingrese su salario bruto: ");
            salario = float.Parse(Console.ReadLine());
            sb = (salario * 20) / 100;

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Su salario real es: " + (salario - sb));


            Console.ReadKey();
        }
    }
}


