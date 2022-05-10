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
        public VentanaPrincipal()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, textBoxPass.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaCliente(textBoxDNI_cliente.Text, textBoxNombre_cliente.Text, textBoxTelefono.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxNombre_mascota.Text, textBoxRaza.Text, textBoxEdad.Text));
        }
    }
}
