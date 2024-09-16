using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Edificio (con datos leídos por GUI)
            Console.Write("Ingrese el código del edificio: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el número de departamentos: ");
            int numeroDepartamentos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de pisos del edificio: ");
            int cantidadPisos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el precio de un departamento en dólares: ");
            double precioDepartamento = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Edificio edificio = new Edificio(codigo, numeroDepartamentos, cantidadPisos, precioDepartamento);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Edificio y visualice sus datos completos
            MostrarDatosEdificio(edificio);

            // Incremente en 20% el precio de un departamento
            edificio.PrecioDepartamento *= 1.20;

            // Invoque nuevamente al método listado
            MostrarDatosEdificio(edificio);

            Console.ReadLine();
        }

        static void MostrarDatosEdificio(Edificio edificio)
        {
            Console.WriteLine("Código: " + edificio.Codigo);
            Console.WriteLine("Número de departamentos: " + edificio.NumeroDepartamentos);
            Console.WriteLine("Cantidad de pisos: " + edificio.CantidadPisos);
            Console.WriteLine("Precio de un departamento: " + edificio.PrecioDepartamento);
            Console.WriteLine("Precio del edificio: " + edificio.PrecioEdificio() + "\n");
            Console.WriteLine("-------------------------------------------------- \n");
        }
    }
}
