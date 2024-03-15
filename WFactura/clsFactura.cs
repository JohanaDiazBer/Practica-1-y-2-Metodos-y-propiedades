using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFactura
{
    public class clsFactura
    {
        private List<ElementoFactura> elementos;

        public clsFactura()
        {
            elementos = new List<ElementoFactura>();
        }

        public void AgregarElemento(string nombre, int cantidad, double precio)
        {
            elementos.Add(new ElementoFactura(nombre, cantidad, precio));
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var elemento in elementos)
            {
                total += elemento.CalcularSubtotal();
            }
            return total;
        }
    }

    public class ElementoFactura
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public ElementoFactura(string nombre, int cantidad, double precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;

        }
        public double CalcularSubtotal()
        {
            return Cantidad * Precio;
        }
    }
}
