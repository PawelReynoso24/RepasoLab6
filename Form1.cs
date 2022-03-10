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
        }

        private void buttonMostrar_Datos_Click(object sender, EventArgs e)
        {

        }
    }
}
