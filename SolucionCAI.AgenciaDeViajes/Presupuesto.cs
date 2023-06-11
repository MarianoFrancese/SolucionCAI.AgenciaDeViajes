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
using Newtonsoft.Json;
using System.Globalization;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }

        private List<VueloEnt> vuelosFiltrados;
        private List<ProductoLineaEnt> productosAgregados;
        string codigo;
        string origen;
        string destino;
        DateTime fechaPartida;
        DateTime fechaArribo;
        TimeSpan tiempoVuelo;
        string aerolinea;
        int cantPasajeros;
        string tipoPasajero;
        string clase;
        decimal tarifa;
        string fechaPartidaFormateada;

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Column13"].Index && e.RowIndex >= 0)

            {

                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                dataGridView2.Rows.RemoveAt(e.RowIndex);

            }   
            
            //MessageBox.Show("Este botón eliminaría un item de la fila, si la fila fuese de un solo producto, desaparecería");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Este botón agrega un item de hospedaje en el presupuesto (por rango de días)");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Este botón agrega un item de vuelo en el presupuesto");

        }

        private void button3_Click(object sender, EventArgs e) //Boton Filtrar Hospedaje
        {
            //MessageBox.Show("Este botón filtra por características de los hospedajes (a revisar)");

            //RellenarPresupuestoTabla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Este botón filtra por características de los vuelos");

            origen = comboBox1.Text;
            destino = comboBox4.Text;
            fechaPartida = dateTimePicker1.Value;
            fechaPartidaFormateada = fechaPartida.ToString("dd/MM/yyyy");
            cantPasajeros = (int)numericUpDown1.Value;
            tipoPasajero = comboBox2.Text;
            clase = comboBox3.Text;

            vuelosFiltrados = ModuloProductos.ListaVuelos(origen, destino, fechaPartidaFormateada, cantPasajeros, tipoPasajero, clase);
            RellenarTabla(vuelosFiltrados, cantPasajeros);

            //Q: What should this void do?
            //A: It should filter the flights by the selected filters and show them in the table

        }

        private void RellenarTabla(List<VueloEnt> vuelosFiltrados, int cantPasajeros)
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
                    cantPasajeros,
                    vuelo.Tarifas[0].TipoPasajero,
                    vuelo.Tarifas[0].Clase,
                    vuelo.Tarifas[0].Precio,
                    vuelo.Tarifas[0].Disponibilidad
                    );
            }
        }

        private void RellenarPresupuestoTabla(List<ProductoLineaEnt> productosAgregados)
        {
            foreach (var producto in productosAgregados)

            {

                dataGridView2.Rows.Add(

                    producto.ProductoV,

                    producto.PrecioUn,

                    producto.Cantidad,

                    producto.SubTotal,

                    producto.IVA,

                    producto.TotalProd

                    );
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {

        }

        private readonly string usuario;
        private void button4_Click(object sender, EventArgs e) //boton para volver al menu princ
        {

            Form menuform = new MenuPrincipal(usuario);
            menuform.Show();
            this.Hide();
        }

        
        private void button12_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

            MessageBox.Show("El Presupuesto ha sido confirmado");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Column12"].Index && e.RowIndex >= 0)

            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string codigo = row.Cells[0].Value.ToString();

                string origen = row.Cells[1].Value.ToString();

                string destino = row.Cells[2].Value.ToString();

                DateTime fechaPartida = Convert.ToDateTime(row.Cells[3].Value.ToString());

                DateTime fechaArribo = Convert.ToDateTime(row.Cells[4].Value.ToString());

                TimeSpan tiempoVuelo = TimeSpan.Parse(row.Cells[5].Value.ToString());

                string aerolinea = row.Cells[6].Value.ToString();

                int cantPasajeros = Convert.ToInt32(row.Cells[7].Value.ToString());

                string tipoPasajero = row.Cells[8].Value.ToString();

                string clase = row.Cells[9].Value.ToString();

                decimal tarifa = Convert.ToDecimal(row.Cells[10].Value.ToString());

                int disponibilidadVuelo = Convert.ToInt32(row.Cells[11].Value.ToString());

                var listaVuelos = ModuloPresupuesto.GenerarListaVuelo(clase, tipoPasajero, tarifa, cantPasajeros, codigo, origen, destino, fechaPartida, fechaArribo, tiempoVuelo, aerolinea);
                var productosAgregados = ModuloPresupuesto.AgregarVueloLinea(listaVuelos);

                textBox11.Text = ModuloPresupuesto.CrearPresupuesto(productosAgregados)[0].NroSeguimiento.ToString();
                textBox5.Text = ModuloPresupuesto.CrearPresupuesto(productosAgregados)[0].Total.ToString();
                RellenarPresupuestoTabla(productosAgregados);

            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
