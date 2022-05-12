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
    public partial class Registro : Form
    {
        Conexion conexion = new Conexion();
        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaUsuario(textBox1.Text, Usuario.Text, Contraseña.Text));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = Contraseña.Text;
            if (checkBox1.Checked)
            {
                Contraseña.UseSystemPasswordChar = false;
                Contraseña.Text = text;

            }
            else
            {
                Contraseña.UseSystemPasswordChar = true;
                Contraseña.Text = text;
            }
        }
    }
}
