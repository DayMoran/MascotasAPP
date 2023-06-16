using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasAPP
{
    internal class Juguete:Producto , IDescuento
    {
        public string Tipo { get; set; }

        public Juguete(string nombre, string marca, decimal precio, string tipo, bool d)
            :base(nombre, marca, precio,d)
        {
            Tipo = tipo;

        }
        public decimal aplicarDescuento(decimal valor)
        {
            return Precio*valor/100;
        }
    }
}
