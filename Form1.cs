using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<Alquileres> alquileres = new List<Alquileres>();
        List<Pago> pago = new List<Pago>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Datos_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            Autos auto = new Autos();
            Alquileres alquiler = new Alquileres();

            cliente.Nombre = textBoxNombre.Text;
            cliente.NIT = textBoxNIT.Text;
            cliente.Dirección = textBoxDireccion.Text;
            clientes.Add(cliente);

            auto.Marca = textBoxMarca.Text;
            auto.Placa = textBoxPlaca.Text;
            auto.Color = textBoxColor.Text;
            auto.Modelo = Convert.To(textBoxModelo.Text);
            auto.Precio = Convert.ToDecimal(textBoxPrecio.Text);
            autos.Add(auto);

            alquiler.Recorrido = Convert.ToDecimal(textBoxRecorrido.Text);
            alquiler.Alquiler = dateTimePickerAlquiler.Value;
            alquiler.Devolución = dateTimePickerDevolución.Value;
            alquiler.Placa = textBoxPlaca.Text;
            alquiler.Nombre = textBoxNombre.Text;
            alquileres.Add(alquiler);

            textBoxDireccion.Text = "";
            textBoxNIT.Text = "";
            textBoxNombre.Text = "";
            textBoxColor.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxPlaca.Text = "";
            textBoxPrecio.Text = "";
            textBoxRecorrido.Text = "";

            Guardar_DatosCliente("Datos de Clientes.txt");
            Guardar_DatosAuto("Datos de Autos.txt");
        }

        private void buttonMostrar_Datos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alquileres.Count; i++)
            {
                for (int j = 0; j < autos.Count; j++)
                {
                    if (alquileres[i].Placa == autos[j].Placa)
                    {
                        Pago pagos = new Pago();
                        pagos.Nombre = alquileres[i].Nombre;
                        pagos.Placa = alquileres[i].Placa;
                        pagos.Marca = autos[j].Marca;
                        pagos.Modelo = autos[j].Modelo;
                        pagos.Color = autos[j].Color;
                        pagos.Precio = autos[j].Precio;
                        pagos.Devolución = alquileres[i].Devolución;
                        pagos.Total_Pagar = alquileres[i].Recorrido * autos[j].Precio;

                        pago.Add(pagos);
                    }
                }
            }

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

            dataGridView3.DataSource = null;
            dataGridView3.Refresh();
            dataGridView3.DataSource = pago;
            dataGridView3.Refresh();
        }

        private void Guardar_DatosCliente(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            //Hay que recorrer la lista para ir guardando cada elemento de la lista            

            foreach (var cl in clientes)
            {
                writer.WriteLine(cl.Nombre);
                writer.WriteLine(cl.NIT);
                writer.WriteLine(cl.Dirección);
            }
            writer.Close();
        }

        private void Guardar_DatosAuto(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            //Hay que recorrer la lista para ir guardando cada elemento de la lista            

            foreach (var au in autos)
            {
                writer.WriteLine(au.Placa);
                writer.WriteLine(au.Marca);
                writer.WriteLine(au.Modelo);
                writer.WriteLine(au.Color);
                writer.WriteLine(au.Precio);
            }
            writer.Close();
        }
    }
}
