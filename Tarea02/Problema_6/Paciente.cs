using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Paciente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        // Constructor
        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        // Métodos de acceso público set/get
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public double Talla { get { return talla; } set { talla = value; } }
        public double Peso { get { return peso; } set { peso = value; } }

        // Método que retorne el texto: “menor de edad” o “mayor de edad”
        public string EdadPaciente()
        {
            if (edad < 18)
            {
                return "menor de edad";
            }
            else
            {
                return "mayor de edad";
            }
        }
    }
}
