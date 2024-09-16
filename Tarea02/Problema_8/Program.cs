using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Asesor (con datos fijos)
            Asesor asesor = new Asesor(1, "Juan Pérez", 160, 25.5);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Asesor y visualice sus datos completos
            MostrarDatosAsesor(asesor);

            // Aumente en 10 el número de horas
            asesor.HorasTrabajadas += 10;

            // Disminuya en 15% la tarifa
            asesor.TarifaPorHora *= 0.85;

            // Invoque nuevamente al método listado
            MostrarDatosAsesor(asesor);

            Console.ReadLine();
        }

        static void MostrarDatosAsesor(Asesor asesor)
        {
            Console.WriteLine("Código: " + asesor.Codigo);
            Console.WriteLine("Nombre: " + asesor.Nombre);
            Console.WriteLine("Horas trabajadas: " + asesor.HorasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + asesor.TarifaPorHora);
            Console.WriteLine("Sueldo bruto: " + asesor.SueldoBruto());
            Console.WriteLine("Descuento: " + asesor.Descuento());
            Console.WriteLine("Sueldo neto: " + asesor.SueldoNeto() +"\n");
            Console.WriteLine("-------------------------------------------- \n");
        }
    }
}
