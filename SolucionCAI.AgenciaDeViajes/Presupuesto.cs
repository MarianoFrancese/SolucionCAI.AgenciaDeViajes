using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SolucionCAI.AgenciaDeViajes.Entidades;
using SolucionCAI.AgenciaDeViajes.Archivos;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }

        private List<VueloEnt> vuelosFiltrados;

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

        private void button3_Click(object sender, EventArgs e) //Boton Filtrar Hospedaje
        {
            MessageBox.Show("Este botón filtra por características de los hospedajes (a revisar)");
        }

        private void button2_Click(object sender, EventArgs e) //Boton Filtrar Vuelos
        {
            //MessageBox.Show("Este botón filtra por características de los vuelos (a revisar)");

            string origen = comboBox1.SelectedItem.ToString();
            string destino = comboBox4.SelectedItem.ToString();
            DateTime fechaPartida = dateTimePicker1.Value;
            int cantPasajeros = (int)numericUpDown1.Value;
            string tipoPasajero = comboBox2.SelectedItem.ToString();
            string clase = comboBox3.SelectedItem.ToString();

            vuelosFiltrados = ModuloProductos.ListaVuelos(origen, destino, fechaPartida, cantPasajeros, tipoPasajero, clase);
            RellenarTabla();
        }

        private void RellenarTabla()
        {
            dataGridView3.Rows.Clear();

            foreach (var vuelo in vuelosFiltrados)
            {
                dataGridView3.Rows.Add(
                    vuelo.Codigo, 
                    vuelo.Origen, 
                    vuelo.Destino, 
                    vuelo.FechaSalida, 
                    vuelo.FechaArribo, 
                    vuelo.TiempoVuelo, 
                    vuelo.Aerolinea,
                    string.Join(",", vuelo.Tarifas)
                    );
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
