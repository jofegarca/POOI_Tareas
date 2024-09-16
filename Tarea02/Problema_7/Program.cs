using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Empleado (con datos leídos por GUI)
            Empleado empleado = new Empleado(123, "Juan Pérez", 987654321, 3200.0);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Empleado y visualice sus datos completos
            MostrarDatosEmpleado(empleado);

            // Cambie el número de celular por 999888777
            empleado.NumeroCelular = 999888777;

            // Aumente el sueldo en 200 soles
            empleado.SueldoSoles += 200.0;

            // Invoque nuevamente al método listado
            MostrarDatosEmpleado(empleado);

            Console.ReadLine();
        }

        static void MostrarDatosEmpleado(Empleado empleado)
        {
            Console.WriteLine("Código: " + empleado.Codigo);
            Console.WriteLine("Nombre: " + empleado.Nombre);
            Console.WriteLine("Número de celular: " + empleado.NumeroCelular);
            Console.WriteLine("Sueldo en soles: " + empleado.SueldoSoles);
            Console.WriteLine("Sueldo empleado: " + empleado.SueldoEmpleado() +"\n");
            Console.WriteLine("------------------------------------------------ \n");
        }
    }
}
