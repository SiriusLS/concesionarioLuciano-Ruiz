using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoCV.clases
{
    public class Venta
    {
        public Vehiculo VehiculoVendido { get; set; }
        public Cliente Cliente { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }

        public string[] MostrarDetalleVenta()
        {
            string[] detalleVenta = {Cliente.Nombre +" " +Cliente.Apellidos, VehiculoVendido.Marca + " " + VehiculoVendido.Modelo, Convert.ToString(VehiculoVendido.Precio),FechaVenta.ToString()};
            return detalleVenta;
        }
    }
}
