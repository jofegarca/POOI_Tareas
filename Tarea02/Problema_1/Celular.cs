using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Celular
    {
        private int numero;
        private string usuario;
        private int segundosConsumidos;
        private double precioPorSegundo;

        // Constructor
        public Celular(int numero, string usuario, int segundosConsumidos, double precioPorSegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precioPorSegundo = precioPorSegundo;
        }

        // Métodos de acceso público set/get
        public int Numero { get { return numero; } set { numero = value; } }
        public string Usuario { get { return usuario; } set { usuario = value; } }
        public int SegundosConsumidos { get { return segundosConsumidos; } set { segundosConsumidos = value; } }
        public double PrecioPorSegundo { get { return precioPorSegundo; } set { precioPorSegundo = value; } }

        // Método que retorne el costo por consumo
        public double CostoPorConsumo()
        {
            return segundosConsumidos * precioPorSegundo;
        }

        // Método que retorne el impuesto por IGV
        public double ImpuestoPorIGV()
        {
            return CostoPorConsumo() * 0.18;
        }

        // Método que retorne el total a pagar
        public double TotalAPagar()
        {
            return CostoPorConsumo() + ImpuestoPorIGV();
        }
    }
}
