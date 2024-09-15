using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargaClientes();
            cargaVehiculos();
            lVventas.View = View.Details;
            lVventas.GridLines = true;
            lVventas.Columns.Add("Cliente");
            lVventas.Columns.Add("Vehiculo");
            lVventas.Columns.Add("Precio");
            lVventas.Columns.Add("Fecha");

            foreach (ColumnHeader column in lVventas.Columns)
            {
                column.Width = 100; 
            }
            Listar();
        }

        void cargaClientes()
        {
            cb_clientes.Items.AddRange(GlobalVar.clientes.ToArray());
        }

        void cargaVehiculos()
        {
            cb_vehiculo.Items.AddRange(GlobalVar.Inventario.Lista().ToArray());
        }
        void Listar()
        {
            lVventas.Items.Clear();
            foreach (Venta detalleVenta in GlobalVar.concesionario.DetalleVentas())
            {
                lVventas.Items.Add(new ListViewItem(detalleVenta.MostrarDetalleVenta()));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Cliente clienteSeleccionado = cb_clientes.SelectedItem as Cliente;
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;
            if (String.IsNullOrEmpty(cb_clientes.Text))
            {
                MessageBox.Show("Seleccione Cliente");
                cb_clientes.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cb_vehiculo.Text))
            {
                MessageBox.Show("Seleccione Vehiculo");
                cb_vehiculo.Focus();
                return;
            }
            GlobalVar.concesionario.RegistrarVenta(vehiculoSeleccionado, clienteSeleccionado);
            cargaClientes();
            cargaVehiculos();
            Listar();
        }

        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;
            decimal precio = vehiculoSeleccionado.Precio;
            tx_precio.Text = Convert.ToString(precio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
