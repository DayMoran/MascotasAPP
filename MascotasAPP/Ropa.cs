using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasAPP
{
    internal class Ropa:Producto, IDescuento
    {
        public string Talla { get; set; }

        public Ropa(string nombre, string marca, decimal precio, string talla, bool d) 
            : base(nombre, marca, precio,d)
        {
            Talla = talla;
        }

        public decimal aplicarDescuento(decimal valor)
        {
            return Precio * valor / 100;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
