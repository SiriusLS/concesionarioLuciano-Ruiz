using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace DemoCV.clases
{
    public class Concesionario
    {
        public string Nombre { get; set; }
        public Inventario Inventario { get; set; }
        public List<Venta> VentasRealizadas = new List<Venta>();

        public void RegistrarVenta(Vehiculo vehiculo, Cliente cliente)
        {
            if (cliente.DineroDisponible >= vehiculo.Precio && GlobalVar.Inventario.ExisteVehiculo(vehiculo))
            {
                Venta nuevaVenta = new Venta()
                {
                    VehiculoVendido = vehiculo,
                    Cliente = cliente,
                    PrecioVenta = vehiculo.Precio,
                    FechaVenta = DateTime.Now
                };
                VentasRealizadas.Add(nuevaVenta);
                cliente.ComprarVehiculo(vehiculo, Inventario);
                MessageBox.Show("Venta realizada");
            }
            else
            {
                MessageBox.Show("Dinero insuficiente");
            }
        }
        public List<Venta> DetalleVentas()
        {
           return VentasRealizadas;
        }
        
    }
}
