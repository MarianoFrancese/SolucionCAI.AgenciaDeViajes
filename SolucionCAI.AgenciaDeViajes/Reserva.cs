using SolucionCAI.AgenciaDeViajes.Archivos;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace SolucionCAI.AgenciaDeViajes
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();

        }

        private List<ItinerarioEnt> itinerariosFiltrados;
        string nroseguimiento;
        private List<PresupuestoEnt> presupuestosFiltrados;
        string descripcion;
        string cliente;

        private void buscarPres_Click(object sender, EventArgs e) //boton buscar presupuestos
        {
            nroseguimiento = textBox7.Text;
            presupuestosFiltrados = ModuloItinerario.ListaPresupuestos(nroseguimiento);

            // Clear the data grid
            dataGridView1.Rows.Clear();

            Console.WriteLine(presupuestosFiltrados);
            if (presupuestosFiltrados.Count > 0)
            {
                RellenarTablaPresup(presupuestosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontraron Presupuestos para ese Nro de Seguimiento");
            }
        }


        private void RellenarTablaPresup(List<PresupuestoEnt> presupuestosFiltrados)
        {
            dataGridView1.Rows.Clear();


            foreach (var presupuesto in presupuestosFiltrados)
            {

                VueloEnt vuelo = presupuestosFiltrados[0].Productos[0].ProductoV;
                HotelEnt hotel = presupuestosFiltrados[0].Productos[0].ProductoH;

                if (vuelo != null && hotel != null)
                {
                    descripcion = $"Codigo Vuelo: {vuelo.Codigo} - Origen: {vuelo.Origen} - Destino: {vuelo.Destino} - Aerolinea: {vuelo.Aerolinea} - Clase: {vuelo.Tarifas[0].Clase} - Tipo Pasajero: {vuelo.Tarifas[0].TipoPasajero} / Codigo Hotel: {hotel.Codigo} - Nombre Hotel: {hotel.Nombre} - Ciudad: {hotel.CodigoCiudad} - Nombre Habitacion: {hotel.Disponibilidad.Nombre}";

                }
                else if (vuelo != null)
                {
                    descripcion = $"Codigo Vuelo: {vuelo.Codigo} - Origen: {vuelo.Origen} - Destino: {vuelo.Destino} - Aerolinea: {vuelo.Aerolinea} - Clase: {vuelo.Tarifas[0].Clase} - Tipo Pasajero: {vuelo.Tarifas[0].TipoPasajero}";
                }
                else if (hotel != null)
                {
                    descripcion = $"Codigo Hotel: {hotel.Codigo} - Nombre Hotel: {hotel.Nombre} - Ciudad: {hotel.CodigoCiudad} - Nombre Habitacion: {hotel.Disponibilidad.Nombre}";
                }


                dataGridView1.Rows.Add(
                presupuesto.NroSeguimiento,
                descripcion,
                presupuesto.Total

                );


            }
        }

        private void buscarPrere_Click(object sender, EventArgs e)
        {
            nroseguimiento = textBox4.Text;

            itinerariosFiltrados = ModuloItinerario.ListaItinerarioPre(nroseguimiento);
            // Clear the data grid
            dataGridView2.Rows.Clear();

            Console.WriteLine(itinerariosFiltrados);
            if (itinerariosFiltrados.Count > 0)
            {
                RellenarTablaPre(itinerariosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontraron PreReservas para ese Nro de Seguimiento");
            }

        }
        private void RellenarTablaPre(List<ItinerarioEnt> itinerariosFiltrados)
        {
            dataGridView2.Rows.Clear();


            foreach (var itinerario in itinerariosFiltrados)
            {
                VueloEnt vuelo = itinerariosFiltrados[0].Presupuesto.Productos[0].ProductoV;
                HotelEnt hotel = itinerariosFiltrados[0].Presupuesto.Productos[0].ProductoH;

                if (vuelo != null && hotel != null)
                {
                    descripcion = $"Codigo Vuelo: {vuelo.Codigo} - Origen: {vuelo.Origen} - Destino: {vuelo.Destino} - Aerolinea: {vuelo.Aerolinea} - Clase: {vuelo.Tarifas[0].Clase} - Tipo Pasajero: {vuelo.Tarifas[0].TipoPasajero} / Codigo Hotel: {hotel.Codigo} - Nombre Hotel: {hotel.Nombre} - Ciudad: {hotel.CodigoCiudad} - Nombre Habitacion: {hotel.Disponibilidad.Nombre}";

                }
                else if (vuelo != null)
                {
                    descripcion = $"Codigo Vuelo: {vuelo.Codigo} - Origen: {vuelo.Origen} - Destino: {vuelo.Destino} - Aerolinea: {vuelo.Aerolinea} - Clase: {vuelo.Tarifas[0].Clase} - Tipo Pasajero: {vuelo.Tarifas[0].TipoPasajero}";
                }
                else if (hotel != null)
                {
                    descripcion = $"Codigo Hotel: {hotel.Codigo} - Nombre Hotel: {hotel.Nombre} - Ciudad: {hotel.CodigoCiudad} - Nombre Habitacion: {hotel.Disponibilidad.Nombre}";
                }

                PersonaFisicaEnt pFisica = itinerariosFiltrados[0].Cliente.PersonaFisica;
                PersonaJuridicaEnt pJuridica = itinerariosFiltrados[0].Cliente.PersonaJuridica;

                if (pFisica != null && pJuridica != null)
                {
                    cliente = $"Nombre: {pFisica.Nombre} - DNI: {pFisica.DNI} / Razon Social: {pJuridica.RazonSocial} - CUIT: {pJuridica.CUIT}";

                }
                else if (pFisica != null)
                {
                    cliente = $"Persona Fisica: Nombre: {pFisica.Nombre} - DNI: {pFisica.DNI} ";
                }
                else if (pJuridica != null)
                {
                    cliente = $"Persona Juridica: Razon Social: {pJuridica.RazonSocial} - CUIT: {pJuridica.CUIT} ";
                }


                dataGridView2.Rows.Add(
                itinerario.Presupuesto.NroSeguimiento,
                descripcion, //ver qué traer de productos, quisiera traer el string que se guarda en el json
                cliente,
                itinerario.Cliente.MedioPago,
                itinerario.Presupuesto.Total

                );



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarRes_Click(object sender, EventArgs e)
        {
            nroseguimiento = textBox1.Text;

            itinerariosFiltrados = ModuloItinerario.ListaItinerarioReserva(nroseguimiento);
            // Clear the data grid
            dataGridView3.Rows.Clear();

            Console.WriteLine(itinerariosFiltrados);
            if (itinerariosFiltrados.Count > 0)
            {
                RellenarTablaReserva(itinerariosFiltrados);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo no puede estar vacío");
            }
            else
            {
                MessageBox.Show("El número de reserva no existe");
            }
        }

        private void RellenarTablaReserva(List<ItinerarioEnt> itinerariosFiltrados)
        {
            dataGridView3.Rows.Clear();


            foreach (var itinerario in itinerariosFiltrados)
            {
                VueloEnt vuelo = itinerariosFiltrados[0].Presupuesto.Productos[0].ProductoV;
                HotelEnt hotel = itinerariosFiltrados[0].Presupuesto.Productos[0].ProductoH;

                if (vuelo != null && hotel != null)
                {
                    descripcion = $"Codigo Vuelo: {vuelo.Codigo} - Origen: {vuelo.Origen} - Destino: {vuelo.Destino} - Aerolinea: {vuelo.Aerolinea} - Clase: {vuelo.Tarifas[0].Clase} - Tipo Pasajero: {vuelo.Tarifas[0].TipoPasajero} / Codigo Hotel: {hotel.Codigo} - Nombre Hotel: {hotel.Nombre} - Ciudad: {hotel.CodigoCiudad} - Nombre Habitacion: {hotel.Disponibilidad.Nombre}";

                }
                else if (vuelo != null)
                {
                    descripcion = $"Codigo Vuelo: {vuelo.Codigo} - Origen: {vuelo.Origen} - Destino: {vuelo.Destino} - Aerolinea: {vuelo.Aerolinea} - Clase: {vuelo.Tarifas[0].Clase} - Tipo Pasajero: {vuelo.Tarifas[0].TipoPasajero}";
                }
                else if (hotel != null)
                {
                    descripcion = $"Codigo Hotel: {hotel.Codigo} - Nombre Hotel: {hotel.Nombre} - Ciudad: {hotel.CodigoCiudad} - Nombre Habitacion: {hotel.Disponibilidad.Nombre}";
                }

                PersonaFisicaEnt pFisica = itinerariosFiltrados[0].Cliente.PersonaFisica;
                PersonaJuridicaEnt pJuridica = itinerariosFiltrados[0].Cliente.PersonaJuridica;

                if (pFisica != null && pJuridica != null)
                {
                    cliente = $"Nombre: {pFisica.Nombre} - DNI: {pFisica.DNI} / Razon Social: {pJuridica.RazonSocial} - CUIT: {pJuridica.CUIT}";

                }
                else if (pFisica != null)
                {
                    cliente = $"Persona Fisica: Nombre: {pFisica.Nombre} - DNI: {pFisica.DNI} ";
                }
                else if (pJuridica != null)
                {
                    cliente = $"Persona Juridica: Razon Social: {pJuridica.RazonSocial} - CUIT: {pJuridica.CUIT} ";
                }


                dataGridView3.Rows.Add(
                itinerario.Presupuesto.NroSeguimiento,
                descripcion,
                cliente,
                itinerario.Cliente.MedioPago,
                itinerario.Presupuesto.Total,
                itinerario.EstadoPago
                );

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            IngresoClientes ingresoClientes = new IngresoClientes(nroseguimiento);
            ingresoClientes.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            // MessageBox.Show("Se reserva el presupuesto y se piden más datos relativos al cliente");
        }

       
        private void button5_Click(object sender, EventArgs e) //muestra form pasajeros
        {
            
            if (dataGridView2.SelectedRows.Count > 0)
            {
                
                int rowIndex = dataGridView2.SelectedRows[0].Index;

                bool tieneVuelo = false;
                ItinerarioEnt selectedItinerario = itinerariosFiltrados[rowIndex];
                foreach (var producto in selectedItinerario.Presupuesto.Productos)
                {
                    if (producto.ProductoV != null)
                    {
                        tieneVuelo = true;
                        break;
                    }
                }
                if (tieneVuelo)
                {
                    Form pasajerosform = new IngresoPasajeros(selectedItinerario);
                    pasajerosform.Show();
                }
                else
                {
                    //acá en realidad hay que reservar de una.
                    MessageBox.Show("El itinerario no tiene vuelos.");
                }

            }
            else
            {
                // No row is currently selected, display an error message or take appropriate action
                MessageBox.Show("Por favor seleccione un itinerario.");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool contieneFilasVacias = false;

            for (int rowIndex = 0; rowIndex < dataGridView3.Rows.Count; rowIndex++)
            {
                DataGridViewRow fila = dataGridView3.Rows[rowIndex];
                bool filaNoVacia = false;

                for (int i = 0; i < dataGridView3.Columns.Count; i++)
                {
                    if (fila.Cells[i].Value != null && !string.IsNullOrEmpty(fila.Cells[i].Value.ToString()))
                    {
                        filaNoVacia = true;
                        break;
                    }
                }

                if (filaNoVacia)
                {
                    contieneFilasVacias = false;
                    if (dataGridView3.Rows.Count > 0 && dataGridView3.Rows[0].Cells[5].Value != null && dataGridView3.Rows[0].Cells[5].Value.ToString() == "Pendiente")
                    {
                        MessageBox.Show("No se puede confirmar una Reserva con Pago Pendiente");
                        break;
                    }

                    else
                    {
                        ItinerarioEnt selectedItinerario = itinerariosFiltrados[rowIndex];
                        DialogResult result = ModuloItinerario.GrabarReservaConfirmada(selectedItinerario);
                        dataGridView3.Rows.Clear();
                        break;
                        
                    }

                }

                else
                {
                    contieneFilasVacias = true;

                    //Console.WriteLine("El DataGridView contiene filas vacías");
                    MessageBox.Show("No hay Reserva para confirmar");
                    break;
                }


            }



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

        private readonly string customusuario;
        private void button8_Click_1(object sender, EventArgs e)
        {
            Form menuform = new MenuPrincipal(customusuario);
            menuform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
