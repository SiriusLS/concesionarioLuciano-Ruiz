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
    public partial class VehiculosForms : Form
    {
        string IdGlobal = "";
        public VehiculosForms()
        {
            InitializeComponent();
        }
        private void VehiculosForms_Load(object sender, EventArgs e)
        {
            LvVehiculos.View = View.Details;
            LvVehiculos.GridLines = true;
            LvVehiculos.Columns.Add("Id");
            LvVehiculos.Columns.Add("Marca");
            LvVehiculos.Columns.Add("Modelo");
            LvVehiculos.Columns.Add("Año");
            LvVehiculos.Columns.Add("Kilometraje");
            LvVehiculos.Columns.Add("Precio");

            LvVehiculos.Columns[0].Width = 0;

            for (int i = 1; i < LvVehiculos.Columns.Count; i++)
            {
                LvVehiculos.Columns[i].Width = 100;
            }
            Listar();
        }

        void Listar()
        {
            LvVehiculos.Items.Clear();
            foreach (Vehiculo vehiculo in GlobalVar.Inventario.Lista())
            {
                LvVehiculos.Items.Add(new ListViewItem(vehiculo.itemView()));
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_marca.Text))
            {
                MessageBox.Show("Debes ingresar una marca");
                tx_marca.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_modelo.Text))
            {
                MessageBox.Show("Debes ingresar un modelo");
                tx_modelo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_año.Text))
            {
                MessageBox.Show("Debes ingresar un año");
                tx_año.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_km.Text))
            {
                MessageBox.Show("Debes ingresar el kilometraje");
                tx_km.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_Precio.Text))
            {
                MessageBox.Show("Debes ingresar el precio");
                tx_Precio.Focus();
                return;
            }
            decimal precio;
            bool isdecimal = decimal.TryParse(tx_Precio.Text, out precio);
            if (!isdecimal)
            {
                MessageBox.Show("Ingrese un precio valido");
                tx_Precio.Focus();
                return;
            }

            int año;
            bool isinta = int.TryParse(tx_año.Text, out año);
            if (!isinta)
            {
                MessageBox.Show("Ingrese un año valido");
                tx_año.Focus();
                return;
            }

            int km;
            bool iskm = int.TryParse(tx_km.Text, out km);
            if (!iskm)
            {
                MessageBox.Show("Ingrese un kilometraje valido");
                tx_km.Focus();
                return;
            }
            Vehiculo v = new Vehiculo()
            {
                Año = Convert.ToInt32(tx_año.Text),
                Kilometraje = Convert.ToInt32(tx_km.Text),
                Precio = Convert.ToDecimal(tx_Precio.Text),
                Marca = tx_marca.Text,
                Modelo = tx_modelo.Text
            };
            if (String.IsNullOrEmpty(IdGlobal))
            {
                GlobalVar.Inventario.AgregarVehiculo(v);
                MessageBox.Show("Vehiculo almacenado");
            }
            else
            {
                Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().Where(x => x.Id == IdGlobal).FirstOrDefault()!;
                vehiculo_modificar.Marca = tx_marca.Text;
                vehiculo_modificar.Modelo = tx_modelo.Text;
                vehiculo_modificar.Año = Convert.ToInt32(tx_año.Text);
                vehiculo_modificar.Kilometraje = Convert.ToInt32(tx_km.Text);
                vehiculo_modificar.Precio = Convert.ToDecimal(tx_Precio.Text);
                IdGlobal = "";
                Listar();
            }

            Listar();
        }
        private void LvVehiculos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
                e.NewWidth = 0;
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String id = LvVehiculos.SelectedItems[0].Text;
            Vehiculo vehiculo_eliminar = GlobalVar.Inventario.Lista().Where(x => x.Id == id).FirstOrDefault()!;
            GlobalVar.Inventario.EliminarVehiculo(vehiculo_eliminar);
            Listar();
            MessageBox.Show("Elemento eliminado");
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String id = LvVehiculos.SelectedItems[0].Text;
            IdGlobal = id;
            Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().Where(x => x.Id == id).FirstOrDefault()!;
            tx_marca.Text = vehiculo_modificar.Marca;
            tx_modelo.Text = vehiculo_modificar.Modelo;
            tx_año.Text = Convert.ToString(vehiculo_modificar.Año);
            tx_km.Text = Convert.ToString(vehiculo_modificar.Kilometraje);
            tx_Precio.Text = Convert.ToString(vehiculo_modificar.Precio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
