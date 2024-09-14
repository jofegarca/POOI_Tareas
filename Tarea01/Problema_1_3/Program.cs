using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto de tipo Coordinador con datos fijos
            Coordinador coordinador = new Coordinador(101, "Ana Lopez", 2, 987654321);

            // Mostrar los datos del coordinador
            coordinador.MostrarDatos();

            // Espera la pulsación de una tecla para finalizar
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
