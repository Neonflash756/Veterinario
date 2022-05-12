using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        DataTable veterinario = new DataTable();
        public VentanaPrincipal()
        {
            InitializeComponent();
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaCliente(textBoxDNI_cliente.Text, textBoxNombre_cliente.Text, textBoxTelefono.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxNombre_mascota.Text, textBoxRaza.Text, textBoxEdad.Text));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busquedaM = id_mascota.Text.ToString();
            conexion.getMascotas(busquedaM);
            dataGridView1.DataSource = conexion.getMascotas(busquedaM);

        }

        private void id_mascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Buscar2_Click(object sender, EventArgs e)
        {
            String busquedaC = id_mascota.Text.ToString();
            conexion.getClientes(busquedaC);
            dataGridView2.DataSource = conexion.getClientes(busquedaC);
        }
    }
}
