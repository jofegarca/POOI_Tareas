using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos y leer los datos del usuario:
            Console.WriteLine("Ingrese el nombre de la persona:");
            string nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese el apellido de la persona:");
            string apellido = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese la edad de la persona:");
            int edad = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese la estatura en metros (por ejemplo, 1.75):");
            double estatura = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese el peso en kilogramos (por ejemplo, 68.5):");
            double peso = double.Parse(Console.ReadLine());
            Console.Clear();

            // Crear objeto de tipo Persona con los datos ingresados por el usuario
            Persona persona = new Persona(nombre, apellido, edad, estatura, peso);

            // Mostrar los datos de la persona
            persona.MostrarDatos();

            // Espera la pulsación de una tecla para finalizar
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
