using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Pelota (con datos fijos)
            Pelota pelota = new Pelota("Adidas", 250.0, 12.5, 22.0, 150.0);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Pelota y visualice sus datos completos
            MostrarDatosPelota(pelota);

            // Disminuya en 25% el precio
            pelota.Precio *= 0.75;

            // Aumente en 1 centímetro el diámetro
            pelota.DiametroCentimetros += 1;

            // Invoque nuevamente al método listado
            MostrarDatosPelota(pelota);

            Console.ReadLine();
        }

        static void MostrarDatosPelota(Pelota pelota)
        {
            Console.WriteLine("Marca: " + pelota.Marca);
            Console.WriteLine("Peso en gramos: " + pelota.PesoGramos);
            Console.WriteLine("Presión en libras: " + pelota.PresionLibras);
            Console.WriteLine("Diámetro en centímetros: " + pelota.DiametroCentimetros);
            Console.WriteLine("Precio: " + pelota.Precio);
            Console.WriteLine("Radio: " + pelota.Radio());
            Console.WriteLine("Volumen: " + pelota.Volumen());
            Console.WriteLine("Descuento: " + pelota.Descuento());
            Console.WriteLine("Importe a pagar: " + pelota.ImportePagar() + "\n");
            Console.WriteLine("---------------------------------------------- \n");
        }
    }
}
