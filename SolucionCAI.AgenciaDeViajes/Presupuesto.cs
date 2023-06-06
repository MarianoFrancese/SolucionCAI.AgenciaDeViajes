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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }

        private List<VueloEnt> vuelosFiltrados;
        string origen;
        string destino;
        DateTime fechaPartida;
        int cantPasajeros;
        string tipoPasajero;
        string clase;
        string fechaPartidaFormateada;

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

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Este botón filtra por características de los vuelos (a revisar)");

            origen = comboBox1.Text;
            destino = comboBox4.Text;
            fechaPartida = dateTimePicker1.Value;
            fechaPartidaFormateada = fechaPartida.ToString("dd/MM/yyyy");
            cantPasajeros = (int)numericUpDown1.Value;
            tipoPasajero = comboBox2.Text;
            clase = comboBox3.Text;

            FiltrarYRellenarTabla();

            //Q: What should this void do?
            //A: It should filter the flights by the selected filters and show them in the table

        }

        private void RellenarTabla(List<VueloEnt> vuelosFiltrados)
        {
            dataGridView1.Rows.Clear();

            foreach (var vuelo in vuelosFiltrados)
            {
                dataGridView1.Rows.Add(
                    vuelo.Codigo,
                    vuelo.Origen,
                    vuelo.Destino,
                    vuelo.FechaSalida,
                    vuelo.FechaArribo,
                    vuelo.TiempoVuelo,
                    vuelo.Aerolinea,
                    vuelo.Tarifas[0].TipoPasajero,
                    vuelo.Tarifas[0].Clase,
                    vuelo.Tarifas[0].Precio
                    );
            }
        }

        private void FiltrarYRellenarTabla()
        {
            vuelosFiltrados = ModuloProductos.ListaVuelos(origen, destino, fechaPartidaFormateada, cantPasajeros, tipoPasajero, clase);
            RellenarTabla(vuelosFiltrados);
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
