using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        /*
           En un nuevo proyecto crear una clase de nombre Producto con los atributos código de tipo entero,
           descripción un String, precio de tipo double y stock de tipo entero; un constructor que permita inicializar
           todos sus atributos y los métodos getter y setter. Desde el método main de clase principal del proyecto
           instanciar un Producto y luego mostrar por consola el estado de todos sus atributos. 
        */

        static void Main(string[] args)
        {
            Producto producto = new Producto(582,"Producto 29",500,12);
            
            Console.WriteLine("El Código es: "+ producto.Codigo);
            Console.WriteLine("La Decripcion es: " + "\"" + producto.Descripcion + "\"");
            Console.WriteLine("El Precio es: " + producto.Precio);
            Console.WriteLine("El Stock es: " + producto.Stock);

            Console.ReadKey();
        }
    }
}
