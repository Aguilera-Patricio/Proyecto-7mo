using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Program
    {
        /*
         En un nuevo proyecto crear una clase que represente una Computadora, usted determine que atributos
         describirían mejor a dicho objeto y luego agregue un constructor para inicializar sus atributos y los
         respectivos métodos getter y setter. Desde el método main de la clase principal del proyecto, instanciar una
         Computadora y mostrar por consola el estado de todos sus atributos.
         */

        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(8,"i5-1035G1","SDD",480,64);

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.WriteLine("La Computadora tiene las siguientes Caracteristicas:\n");

            Console.WriteLine("RAM : " + computadora.Ram);
            Console.WriteLine("Procesador: " + computadora.Procesador);
            Console.WriteLine("Tipo de Disco: " + computadora.Disco);
            Console.WriteLine("Cantidad de memoria del disco: " + computadora.Memoria + "GB");
            Console.WriteLine("Cantidad de Bits: " + computadora.Bits + "bits");

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");


            Console.ReadKey();
        }
    }
}
