﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int numeroCelular;
        private double sueldoSoles;

        // Constructor
        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldoSoles = sueldoSoles;
        }

        // Métodos de acceso público set/get
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int NumeroCelular { get { return numeroCelular; } set { numeroCelular = value; } }
        public double SueldoSoles { get { return sueldoSoles; } set { sueldoSoles = value; } }

        // Método que retorne un texto indicando si el sueldo es “mayor a 3500”, “menor a 3500” o “igual a 3500”
        public string SueldoEmpleado()
        {
            if (sueldoSoles > 3500)
            {
                return "mayor a 3500";
            }
            else if (sueldoSoles < 3500)
            {
                return "menor a 3500";
            }
            else
            {
                return "igual a 3500";
            }
        }
    }
}
