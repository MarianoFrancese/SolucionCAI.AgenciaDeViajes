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
            //MessageBox.Show("Este botón agrega un item de vuelo en el presupuesto");

        }

        private void button3_Click(object sender, EventArgs e) //Boton Filtrar Hospedaje
        {
            //MessageBox.Show("Este botón filtra por características de los hospedajes (a revisar)");

            //RellenarPresupuestoTabla();

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

        private void RellenarPresupuestoTabla(List<ProductoLineaEnt> productosagregados)
        {
            dataGridView2.Rows.Clear();

            foreach (var producto in productosagregados)
            {
                dataGridView2.Rows.Add(
                    producto.ProductoV.ToString(),
                    producto.PrecioUn,
                    producto.Cantidad,
                    producto.Descuento,
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
        private void button4_Click_1(object sender, EventArgs e)
        {

            Form menuform = new MenuPrincipal(usuario);
            menuform.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
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
            codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            origen = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            destino = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            fechaPartida = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            fechaArribo = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            tiempoVuelo = TimeSpan.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            aerolinea = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            tipoPasajero = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            clase = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            tarifa = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            cantPasajeros = (int)numericUpDown1.Value;

            TarifaEnt tarifaVuelo = new TarifaEnt
            {
                Clase = clase.ToCharArray()[0],
                TipoPasajero = tipoPasajero.ToCharArray()[0],
                Precio = tarifa,
                Disponibilidad = cantPasajeros,
            };

            List<TarifaEnt> listaTarifas = new List<TarifaEnt>();
            listaTarifas.Add(tarifaVuelo);

            VueloEnt vueloSeleccionado = new VueloEnt
            {
                Codigo = codigo,
                Origen = origen,
                Destino = destino,
                FechaSalida = fechaPartida,
                FechaArribo = fechaArribo,
                TiempoVuelo = tiempoVuelo,
                Aerolinea = aerolinea,
                Tarifas = listaTarifas,
            };

            var productosAgregados = ModuloPresupuesto.LineaProductoVuelos(vueloSeleccionado);
            RellenarPresupuestoTabla(productosAgregados);
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
