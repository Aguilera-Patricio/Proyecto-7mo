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
         * En un nuevo proyecto crear una clase de nombre Jugador con los atributos: nombre, puntaje,
         * nacionalidad y edad. Luego un constructor vació y un constructor que inicialice todos sus atributos; agregue
         * además los respectivos métodos getter y setter. Desde el método main de la clase principal del proyecto
         * crear un Jugador utilizando el constructor vacío; luego, a dicho jugador darle de nombre “Juan”, con 140
         * puntos, de nacionalidad “Argentino” y una edad de 29 años; por último mostrar por consola el estado de
         * cada uno de sus atributos.
        */

        static void Main(string[] args)
        {

            Jugador jugador = new Jugador();

            jugador.Nombre = "Juan";
            jugador.Puntaje = 140;
            jugador.Nacionalidad = "Argentino";
            jugador.Edad = 29;


            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.WriteLine("Datos del Jugador:\n");

            Console.WriteLine("Nombre: " + jugador.Nombre);
            Console.WriteLine("Puntaje: " + jugador.Puntaje);
            Console.WriteLine("Nacionalidad: " + jugador.Nacionalidad);
            Console.WriteLine("Ead: " + jugador.Edad);

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
