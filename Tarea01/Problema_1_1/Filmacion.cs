using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Filmacion
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public double PrecioSoles { get; set; }

        //Constructor
        public Filmacion(int codigo, string titulo, int duracion, double precioSoles)
        {
            Codigo = codigo;
            Titulo = titulo;
            Duracion = duracion;
            PrecioSoles = precioSoles;
        }

        // Método que retorna el precio en dólares
        public double ObtenerPrecioEnDolares()
        {
            double tipoCambio = 3.59;
            return PrecioSoles / tipoCambio;
        }

        // Método para visualizar los datos de la filmación
        public void MostrarDatos()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Duración (min): " + Duracion);
            Console.WriteLine("Precio en soles: " + PrecioSoles);
            Console.WriteLine("Precio en dólares: " + ObtenerPrecioEnDolares());
            Console.WriteLine("-------------------------------------------------");
        }


    }
}
