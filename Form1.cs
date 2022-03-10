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

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Datos_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.Nombre = textBoxNombre.Text;
            cliente.NIT = textBoxNIT.Text;
            cliente.Dirección = textBoxDireccion.Text;
            clientes.Add(cliente);

            textBoxDireccion.Text = "";
            textBoxNIT.Text = "";
            textBoxNombre.Text = "";
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
        }
    }
}
