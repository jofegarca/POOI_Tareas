using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_3
{
    internal class Coordinador
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public int NumeroCelular { get; set; }

        //Constructor
        public Coordinador(int codigo, string nombre, int categoria, int numeroCelular)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            NumeroCelular = numeroCelular;
        }

        public double ObtenerSueldo()
        {
            switch (Categoria)
            {
                case 0:
                    return 8500;
                case 1:
                    return 6850;
                case 2:
                    return 5500;
                default:
                    return 0;
            }
        }

        // Método para visualizar los datos del coordinador
        public void MostrarDatos()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Categoría: " + Categoria);
            Console.WriteLine("Número de Celular: " + NumeroCelular);
            Console.WriteLine("Sueldo: S/ " + ObtenerSueldo());
        }

    }
}
