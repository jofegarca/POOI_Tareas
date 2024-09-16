using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Obrero(con datos fijos)
            Obrero obrero = new Obrero(123, "Juan Pérez", 40, 20.00);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Obrero y visualice sus datos completos
            MostrarDatosObrero(obrero);

            // Aumente en 8 el número horas trabajadas
            obrero.HorasTrabajadas += 8;

            // Disminuya en 1.5% la tarifa por hora
            obrero.TarifaPorHora *= 0.985;

            // Invoque nuevamente al método listado
            MostrarDatosObrero(obrero);

            Console.ReadLine();
        }

        static void MostrarDatosObrero(Obrero obrero)
        {
            Console.WriteLine("Código: " + obrero.Codigo);
            Console.WriteLine("Nombre: " + obrero.Nombre);
            Console.WriteLine("Horas trabajadas: " + obrero.HorasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + obrero.TarifaPorHora);
            Console.WriteLine("Sueldo bruto: " + obrero.SueldoBruto());
            Console.WriteLine("Descuento AFP: " + obrero.DescuentoAFP());
            Console.WriteLine("Descuento EPS: " + obrero.DescuentoEPS());
            Console.WriteLine("Sueldo neto: " + obrero.SueldoNeto()+"\n");
            Console.WriteLine("-------------------------------------------- \n");
        }
    }
}
