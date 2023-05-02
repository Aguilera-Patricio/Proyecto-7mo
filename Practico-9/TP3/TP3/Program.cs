using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Program
    {
        /*
         *En un nuevo proyecto, crear una clase de nombre Circulo, con los atributos PI que es una constante con el valor 3.14 y radio; un constructor que permita inicializar el radio del círculo; los métodos “get” y “set” para radio y los siguientes métodos adicionales:
         *
         * calcularArea(): este método retornará la superficie del círculo.
         * calcularPerímetro(): este método retornará el perímetro del círculo.
         *
         *Luego desde la clase principal del proyecto (la que contiene el método main) se pide:
         *
         *a) Crear un objeto Circulo con radio 5.75.
         *
         *Luego utilizando sus métodos:
         *
         *b) Mostrar por consola su perímetro
         *c) Mostrar por consola su superficie. 
         */

        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(5.75);

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.WriteLine("El Circulo tiene un Radio de 5,75\n\n");

            Console.WriteLine("El Perímetro del Circulo es: " + circulo.calcularPerimetro());
            Console.WriteLine("La Superficie del Circulo es: " + circulo.calcularArea());

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");


            Console.ReadKey();
        }
    }
}
