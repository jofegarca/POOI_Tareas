using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Edificio
    {
        private int codigo;
        private int numeroDepartamentos;
        private int cantidadPisos;
        private double precioDepartamento;

        // Constructor
        public Edificio(int codigo, int numeroDepartamentos, int cantidadPisos, double precioDepartamento)
        {
            this.codigo = codigo;
            this.numeroDepartamentos = numeroDepartamentos;
            this.cantidadPisos = cantidadPisos;
            this.precioDepartamento = precioDepartamento;
        }

        // Métodos de acceso público set/get
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public int NumeroDepartamentos { get { return numeroDepartamentos; } set { numeroDepartamentos = value; } }
        public int CantidadPisos { get { return cantidadPisos; } set { cantidadPisos = value; } }
        public double PrecioDepartamento { get { return precioDepartamento; } set { precioDepartamento = value; } }

        // Método que retorne el precio en dólares del edificio
        public double PrecioEdificio()
        {
            return numeroDepartamentos * precioDepartamento;
        }
    }
}
