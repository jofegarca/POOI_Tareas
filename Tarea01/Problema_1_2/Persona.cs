using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_2
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }

        //Constructor
        public Persona(string nombre, string apellido, int edad, double estatura, double peso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Estatura = estatura;
            Peso = peso;
        }

        // Método que retorna el estado de la persona: menor o mayor de edad
        public string ObtenerEstadoEdad()
        {
            return Edad >= 18 ? "Mayor de edad" : "Menor de edad";
        }

        // Método que retorna el índice de masa corporal de la persona
        public double CalcularIMC()
        {
            return Peso / (Estatura * Estatura);
        }

        // Método para visualizar los datos de la persona
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Estado: " + ObtenerEstadoEdad());
            Console.WriteLine("Estatura (m): " + Estatura);
            Console.WriteLine("Peso (kg): " + Peso);
            Console.WriteLine("Índice de Masa Corporal (IMC): " + CalcularIMC());
        }


    }
}
