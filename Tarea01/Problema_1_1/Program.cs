using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto de tipo Filmacion con datos fijos
            Filmacion filmacion = new Filmacion(1, "Harry Potter y La Orden del Fenix", 120, 50.00);
            Filmacion filmacion1 = new Filmacion(2, "Spider Man 1", 90, 60.00);

            // Mostrar los datos de la filmación
            filmacion.MostrarDatos();
            filmacion1.MostrarDatos();

            // Espera la pulsación de una tecla para finalizar
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
