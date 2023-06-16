using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasAPP
{
    internal class Mascota: IDescuento
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public decimal Edad { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }

        public Mascota(string nombre, string especie, decimal edad, decimal precio, bool disponible)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Precio = precio;
            Disponible = disponible;
        }

        public decimal aplicarDescuento(decimal valor)
        {
            return Precio * valor / 100;
        }

    }
}
