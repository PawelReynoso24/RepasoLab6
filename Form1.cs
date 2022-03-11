using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoLab6
{
    public partial class Form1 : Form
    {

        List<Clientes> clientes = new List<Clientes>();
        List<Autos> autos = new List<Autos>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Datos_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            Autos auto = new Autos();

            cliente.Nombre = textBoxNombre.Text;
            cliente.NIT = textBoxNIT.Text;
            cliente.Dirección = textBoxDireccion.Text;
            clientes.Add(cliente);

            auto.Marca = textBoxMarca.Text;
            auto.Placa = textBoxPlaca.Text;
            auto.Color = textBoxColor.Text;
            auto.Modelo = textBoxModelo.Text;
            auto.Precio = Convert.ToDecimal(textBoxPrecio.Text);
            auto.Recorrido = Convert.ToDecimal(textBoxRecorrido.Text);
            auto.Alquiler = dateTimePickerAlquiler.Value;
            auto.Devolución = dateTimePickerDevolución.Value;
            autos.Add(auto);

            textBoxDireccion.Text = "";
            textBoxNIT.Text = "";
            textBoxNombre.Text = "";
            textBoxColor.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxPlaca.Text = "";
            textBoxPrecio.Text = "";
            textBoxRecorrido.Text = "";
        }

        private void buttonMostrar_Datos_Click(object sender, EventArgs e)
        {
            Mostrar_GridView();
        }

        private void Mostrar_GridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = clientes;
            dataGridView1.Refresh();

            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = autos;
            dataGridView2.Refresh();
        }
    }
}
