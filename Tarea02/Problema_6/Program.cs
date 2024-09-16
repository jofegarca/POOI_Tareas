using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Paciente (con datos fijos)
            Paciente paciente = new Paciente("Juan", "Pérez", 17, 1.70, 60.0);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Paciente y visualice sus datos completos
            MostrarDatosPaciente(paciente);

            // Modifique la edad del paciente
            paciente.Edad = 20;

            // Invoque nuevamente al método listado
            MostrarDatosPaciente(paciente);

            Console.ReadLine();
        }

        static void MostrarDatosPaciente(Paciente paciente)
        {
            Console.WriteLine("Nombre: " + paciente.Nombre);
            Console.WriteLine("Apellido: " + paciente.Apellido);
            Console.WriteLine("Edad: " + paciente.Edad);
            Console.WriteLine("Talla: " + paciente.Talla);
            Console.WriteLine("Peso: " + paciente.Peso);
            Console.WriteLine("Edad paciente: " + paciente.EdadPaciente()+"\n");
            Console.WriteLine("----------------------------------------------- \n");
        }
    }
}
