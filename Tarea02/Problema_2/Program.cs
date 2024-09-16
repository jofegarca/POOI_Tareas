using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Computadora
            Computadora computadora = new Computadora(123, "HP", "Negro", 500.00);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Computadora y visualice sus datos completos
            MostrarDatosComputadora(computadora);

            // Disminuya en 10% el precio en dólares de la computadora
            computadora.PrecioEnDolares *= 0.90;

            // Invoque nuevamente al método listado
            MostrarDatosComputadora(computadora);

            Console.ReadLine();
        }

        static void MostrarDatosComputadora(Computadora computadora)
        {
            Console.WriteLine("Código: " + computadora.Codigo);
            Console.WriteLine("Marca: " + computadora.Marca);
            Console.WriteLine("Color: " + computadora.Color);
            Console.WriteLine("Precio en dólares: " + computadora.PrecioEnDolares);
            Console.WriteLine("Precio en soles: " + computadora.PrecioEnSoles());
            Console.WriteLine("Precio en euros: " + computadora.PrecioEnEuros() + "\n");
            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
