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
            ContraseñaLogin.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioLogin.Text;
            string contraseña = ContraseñaLogin.Text;

            var login = new Validaciones();
            bool esValido = login.ValidaUsuario(usuario, contraseña);

            if (esValido)
            {
                Form MenuPrincipal = new SolucionCAI.AgenciaDeViajes.MenuPrincipal();
                MenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

    }
}
