using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Jugador
    {
        private string nombre;
        private double puntaje;
        private string nacionalidad;
        private int edad;

        public Jugador () 
        {

        }
        public Jugador (string nombre, double puntaje, string nacionalidad, int edad)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.nacionalidad = nacionalidad;
            this.edad = edad;
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Puntaje 
        {
            get { return puntaje; }
            set { puntaje = value; }
        }
        
        public string Nacionalidad 
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public int Edad 
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
