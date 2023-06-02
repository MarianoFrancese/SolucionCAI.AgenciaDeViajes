using SolucionCAI.AgenciaDeViajes.Archivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            var login = new Validaciones();
            bool esValido = login.ValidaUsuario(usuario, contraseña);

            if (esValido)
            {
                MenuPrincipal.Mostrar();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
