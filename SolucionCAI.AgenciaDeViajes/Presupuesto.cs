﻿using System;
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
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class Presupuesto : Form
    {
        private List<VueloEnt> vuelosFiltrados = new List<VueloEnt>();
        private VueloEnt vuelo = new VueloEnt();
        private ProductoLineaEnt productoAgregado = new ProductoLineaEnt();
        private HotelEnt hotelFiltrado = new HotelEnt();
        private List<ProductoLineaEnt> productosPresupuesto = new List<ProductoLineaEnt>();
        private List<HotelEnt> hotelesFiltrados = new List<HotelEnt>();
        string origen;
        string destino;
        DateTime fechaPartida;
        string fechaPartidaFormateada;
        int cantPasajeros;
        string tipoPasajero;
        string clase;
        decimal value;
        string producto;
        decimal precio;
        int cantidad;
        decimal total;
        string ciudad;
        DateTime fechaEntrada;
        DateTime fechaSalida;
        string fechaEntradaFormateada;
        string fechaSalidaFormateada;
        int cantHuespedes;
        string tipoHabitacion;

        public Presupuesto()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Column13"].Index && e.RowIndex >= 0)

            {

                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                dataGridView2.Rows.RemoveAt(e.RowIndex);  //ojo acá que da excepción si se elimina la fila antes de confirmar

            }
            CalcularTotal();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["Column30"].Index && e.RowIndex >= 0)

            {

                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];

                string codigo = row.Cells[0].Value.ToString();
                string hotel = row.Cells[1].Value.ToString();
                string ciudad = row.Cells[2].Value.ToString();
                DateTime fechaEntrada = Convert.ToDateTime(row.Cells[3].Value.ToString());
                DateTime fechaSalida = Convert.ToDateTime(row.Cells[4].Value.ToString());
                string direccion = row.Cells[5].Value.ToString();
                int calificacion = Convert.ToInt32(row.Cells[6].Value.ToString());
                string tipoHab = row.Cells[7].Value.ToString();
                int capacidad = Convert.ToInt32(row.Cells[8].Value.ToString());
                decimal tarifa = Convert.ToDecimal(row.Cells[9].Value.ToString());
                int adultos = Convert.ToInt32(row.Cells[10].Value.ToString());
                int menores = Convert.ToInt32(row.Cells[11].Value.ToString());
                int infantes = Convert.ToInt32(row.Cells[12].Value.ToString());

                hotelFiltrado = ModuloPresupuesto.GenerarHotel(codigo, hotel, ciudad, fechaEntrada, fechaSalida, direccion, calificacion, tipoHab, capacidad, tarifa, adultos, menores, infantes);
                productoAgregado = ModuloPresupuesto.AgregarHotelLinea(hotelFiltrado);
                productosPresupuesto.Add(productoAgregado);
                textBox11.Text = ModuloPresupuesto.CrearPresupuesto(productosPresupuesto, 0).NroSeguimiento.ToString();
                RellenarPresupuestoTablaHoteles(productosPresupuesto);
                CalcularTotal();

            }
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
            RellenarTablaVuelos(vuelosFiltrados, cantPasajeros);


        }

        private void RellenarTablaVuelos(List<VueloEnt> vuelosFiltrados, int cantPasajeros)
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

                    producto.TarifaV.Precio,

                    producto.Cantidad,

                    producto.SubTotal,

                    producto.IVA,

                    producto.TotalProd

                    );
            }
        }

        private void RellenarPresupuestoTablaHoteles(List<ProductoLineaEnt> productosAgregados)
        {
            foreach (var producto in productosAgregados)
            {

                dataGridView2.Rows.Add(

                    producto.ProductoH,

                    producto.DisponibilidadH.TarifaHab,

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
            List<ProductoLineaEnt> productosAGrabar = new List<ProductoLineaEnt>();
            ProductoLineaEnt productos;
            //VueloEnt vuelo = ModuloProductos.ObtenerVueloPorID(dataGridView2.Rows.Cells[0]?.Value?.ToString()); //agregar uid a la tabla
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila != null)
                {
                    producto = fila.Cells[0]?.Value?.ToString();
                    precio = Convert.ToDecimal(fila.Cells[1]?.Value?.ToString());
                    cantidad = Convert.ToInt32(fila.Cells[2]?.Value?.ToString());
                    //subtotal = Convert.ToDecimal(fila.Cells[3]?.Value?.ToString());
                    //iva = Convert.ToDecimal(fila.Cells[4]?.Value?.ToString());
                    total = Convert.ToDecimal(textBox5.Text);
                    productos = new ProductoLineaEnt
                    {
                        ProductoV = vuelo,
                        ProductoH = null,
                        Cantidad = cantidad
                    };
                    productosAGrabar.Add(productos);
                }

            }
            productosAGrabar.RemoveAt(productosAGrabar.Count - 1);
            Console.WriteLine(productosAGrabar);


            var listaProd = ModuloPresupuesto.CrearPresupuesto(productosAGrabar, total);
            var presupuesto = ModuloPresupuesto.GrabarPresupuesto(listaProd);

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            comboBox1.Text = string.Empty;
            comboBox4.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox5.Text = string.Empty;
            groupBox3.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;

        }

        private void tabPage1_Click(object sender, EventArgs e)
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

                vuelo = ModuloPresupuesto.GenerarVuelo(clase, tipoPasajero, tarifa, cantPasajeros, codigo, origen, destino, fechaPartida, fechaArribo, tiempoVuelo, aerolinea);
                productoAgregado = ModuloPresupuesto.AgregarVueloLinea(vuelo);
                productosPresupuesto.Add(productoAgregado);
                textBox11.Text = ModuloPresupuesto.CrearPresupuesto(productosPresupuesto, 0).NroSeguimiento.ToString();

                RellenarPresupuestoTabla(productosPresupuesto);
                CalcularTotal();

            }
        }


        public void CalcularTotal()
        {
            value = 0;
            int columnIndex = dataGridView2.Columns["TotalProducto"].Index;
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila.Cells[columnIndex].Value != null)
                {
                    DataGridViewCell cell = fila.Cells[5];
                    string cellValue = cell.Value?.ToString();
                    if (decimal.TryParse(cellValue, out decimal total))
                    {
                        value += total;

                    }

                }
            }
            textBox5.Text = value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RellenarTablaHoteles(List<HotelEnt> hotelesFiltrados, string fechaEntradaFormateada, string fechaSalidaFormateada)
        {
            dataGridView3.Rows.Clear();

            string direccionFormateada = string.Join(", ", hotelesFiltrados[0].Direccion.GetType().GetProperties().Select(p => $"{p.Name}: {p.GetValue(hotelesFiltrados[0].Direccion)}"));

            foreach (var hotel in hotelesFiltrados)
            {
                dataGridView3.Rows.Add(
                    hotel.Codigo,
                    hotel.Nombre,
                    hotel.CodigoCiudad,
                    fechaEntradaFormateada,
                    fechaSalidaFormateada,
                    direccionFormateada,
                    hotel.Calificacion,
                    hotel.Disponibilidad.Nombre,
                    hotel.Disponibilidad.Capacidad,
                    hotel.Disponibilidad.TarifaHab,
                    hotel.Disponibilidad.Adultos,
                    hotel.Disponibilidad.Menores,
                    hotel.Disponibilidad.Infantes
                    );
            }
        }

        private void BuscarHosp_Click(object sender, EventArgs e)
        {
            ciudad = comboBox5.Text;
            fechaEntrada = dateTimePicker2.Value;
            fechaEntradaFormateada = fechaEntrada.ToString("dd/MM/yyyy");
            fechaSalida = dateTimePicker3.Value;
            fechaSalidaFormateada = fechaSalida.ToString("dd/MM/yyyy");
            cantHuespedes = (int)numericUpDown2.Value;
            tipoHabitacion = comboBox6.Text;


            hotelesFiltrados = ModuloProductos.ListaHoteles(ciudad, fechaEntradaFormateada, fechaSalidaFormateada, cantHuespedes, tipoHabitacion);

            Console.WriteLine(hotelesFiltrados);
            if (hotelesFiltrados.Count > 0)
            {
                RellenarTablaHoteles(hotelesFiltrados, fechaEntradaFormateada, fechaSalidaFormateada);
            }
            else
            {
                MessageBox.Show("No se encontraron hoteles disponibles");
            }
        }
    }
}
