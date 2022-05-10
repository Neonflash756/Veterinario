using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_Entrar_Click(object sender, EventArgs e)
        {
            if (conexion.loginVeterinario(Usuario.Text, Contraseña.Text))
            {
                this.Hide();
                VentanaPrincipal v = new VentanaPrincipal();
                v.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = Contraseña.Text;
            if(checkBox1.Checked)
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
