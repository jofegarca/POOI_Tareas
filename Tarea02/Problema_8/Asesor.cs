using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaPorHora;

        // Constructor
        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        // Métodos de acceso público set/get
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int HorasTrabajadas { get { return horasTrabajadas; } set { horasTrabajadas = value; } }
        public double TarifaPorHora { get { return tarifaPorHora; } set { tarifaPorHora = value; } }

        // Método que retorne el sueldo bruto (horas*tarifa)
        public double SueldoBruto()
        {
            return horasTrabajadas * tarifaPorHora;
        }

        // Método que retorne el descuento (15% del sueldo bruto)
        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }

        // Método que retorne el sueldo neto (sueldo bruto - descuento)
        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
    }
}
