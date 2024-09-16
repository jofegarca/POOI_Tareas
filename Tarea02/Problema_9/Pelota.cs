using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Pelota
    {
        private string marca;
        private double pesoGramos;
        private double presionLibras;
        private double diametroCentimetros;
        private double precio;

        // Constructor
        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCentimetros, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCentimetros = diametroCentimetros;
            this.precio = precio;
        }

        // Métodos de acceso público set/get
        public string Marca { get { return marca; } set { marca = value; } }
        public double PesoGramos { get { return pesoGramos; } set { pesoGramos = value; } }
        public double PresionLibras { get { return presionLibras; } set { presionLibras = value; } }
        public double DiametroCentimetros { get { return diametroCentimetros; } set { diametroCentimetros = value; } }
        public double Precio { get { return precio; } set { precio = value; } }

        // Método que retorne el radio (diámetro / 2)
        public double Radio()
        {
            return diametroCentimetros / 2;
        }

        // Método que retorne el volumen del balón (4 * 3.1416 * radio* radio * radio / 3)
        public double Volumen()
        {
            double radio = Radio();
            return 4 * 3.1416 * radio * radio * radio / 3;
        }

        // Método que retorne el descuento (10% del precio)
        public double Descuento()
        {
            return precio * 0.10;
        }

        // Método que retorne el importe a pagar (precio - descuento)
        public double ImportePagar()
        {
            return precio - Descuento();
        }
    }
}
