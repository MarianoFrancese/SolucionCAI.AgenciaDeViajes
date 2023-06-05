using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class MenuPrincipal : Form
    {
        private readonly string customusuario;

        public MenuPrincipal(string customusuario)
        {
            InitializeComponent();
            this.customusuario = customusuario;
            label3.Text = "Bienvenid@ " + Environment.NewLine + this.customusuario; // Set the Label's text using the CustomLabelText property
        }
        
           

        private void button1_Click(object sender, EventArgs e)
        {
            Form presupuestoForm = new SolucionCAI.AgenciaDeViajes.Presupuesto();
            presupuestoForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form reservasForm = new SolucionCAI.AgenciaDeViajes.Reserva();
            reservasForm.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
