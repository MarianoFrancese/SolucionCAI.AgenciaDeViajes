using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se prerreserva el presupuesto y se piden más datos relativos al cliente");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se reserva el presupuesto y se piden más datos relativos al cliente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se reserva la prereserva (datos ya cargados)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirma reserva");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busqueda con filtros aplicados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busqueda con filtros aplicados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busqueda con filtros aplicados");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
