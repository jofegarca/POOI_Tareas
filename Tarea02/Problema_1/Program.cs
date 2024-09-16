using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Celular
            Celular celular = new Celular(123, "Juan Pérez", 100, 0.10);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Celular y visualice sus datos completos
            MostrarDatosCelular(celular);

            // Aumente en 20 el número de segundos consumidos, disminuya en 5% el precio por segundo
            celular.SegundosConsumidos += 20;
            celular.PrecioPorSegundo *= 0.95;

            // Invoque nuevamente al método listado
            MostrarDatosCelular(celular);

            Console.ReadLine();
        }

        static void MostrarDatosCelular(Celular celular)
        {
            Console.WriteLine("Número: " + celular.Numero);
            Console.WriteLine("Usuario: " + celular.Usuario);
            Console.WriteLine("Segundos consumidos: " + celular.SegundosConsumidos);
            Console.WriteLine("Precio por segundo: " + celular.PrecioPorSegundo);
            Console.WriteLine("Costo por consumo: " + celular.CostoPorConsumo());
            Console.WriteLine("Impuesto por IGV: " + celular.ImpuestoPorIGV());
            Console.WriteLine("Total a pagar: " + celular.TotalAPagar() +"\n");
            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
