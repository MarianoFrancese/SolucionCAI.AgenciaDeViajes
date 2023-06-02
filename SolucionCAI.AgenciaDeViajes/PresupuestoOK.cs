using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class PresupuestoOK : Form
    {
        public PresupuestoOK()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Este botón eliminaría un item de la fila, si la fila fuese de un solo producto, desaparecería");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botón busca por CUIT, si lo encontrase, los demás textboxes se llenarían con los datos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botón generaría el presupuesto con los datos de clientes encontrados o agregados y con los items seleccionados");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Este botón agrega un item de hospedaje en el presupuesto (por rango de días)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Este botón agrega un item de vuelo en el presupuesto");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botón filtra por características de los hospedajes (a revisar)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botón filtra por características de los vuelos (a revisar)");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
