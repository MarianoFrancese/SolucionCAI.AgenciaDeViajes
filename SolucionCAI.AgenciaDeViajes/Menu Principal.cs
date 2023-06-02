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
    public partial class segundoForm : Form
    {
        public segundoForm()
        {
            InitializeComponent();
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
    }
}
