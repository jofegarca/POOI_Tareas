using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Computadora
    {
        private int codigo;
        private string marca;
        private string color;
        private double precioEnDolares;

        // Constructor
        public Computadora(int codigo, string marca, string color, double precioEnDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioEnDolares = precioEnDolares;
        }

        // Métodos de acceso público set/get
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Color { get { return color; } set { color = value; } }
        public double PrecioEnDolares { get { return precioEnDolares; } set { precioEnDolares = value; } }

        // Método que retorne el precio de la computadora en soles
        public double PrecioEnSoles()
        {
            return precioEnDolares * 3.35;
        }

        // Método que retorne el precio de la computadora en euros
        public double PrecioEnEuros()
        {
            return precioEnDolares / 1.20;
        }
    }
}
