using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasAPP
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }

        public bool Disponible { get; set; }

        public Producto(string nom, string marca, decimal precio, bool disponible)
        {
            this.Nombre = nom;
            this.Marca = marca;
            this.Precio = precio;
            Disponible = disponible;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Marca: {Marca}, Precio: {Precio}, Disponible:{Disponible}";
        }
    }
}
