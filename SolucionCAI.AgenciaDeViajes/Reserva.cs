using SolucionCAI.AgenciaDeViajes.Archivos;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void buscarPres_Click(object sender, EventArgs e) //boton buscar presupuestos
        {
            nroseguimiento = textBox7.Text;
            presupuestosFiltrados = ModuloItinerario.ListaPresupuestos(nroseguimiento);
           
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
                                
                 if (presupuesto.Productos[0].ProductoV != null)
                {
                    dataGridView1.Rows.Add(
                    presupuesto.NroSeguimiento,
                    presupuesto.Productos[0].ProductoV,
                    presupuesto.Total
                    
                    );
                }
                else if (presupuesto.Productos[0].ProductoH != null)
                {
                    dataGridView1.Rows.Add(
                    presupuesto.NroSeguimiento,
                    presupuesto.Productos[0].ProductoH,
                    presupuesto.Total
                    );
                }


            }
        }

        private void buscarPrere_Click(object sender, EventArgs e)
        {
            nroseguimiento = textBox4.Text;

            itinerariosFiltrados = ModuloItinerario.ListaItinerarioPre(nroseguimiento);
            
            
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
                if (itinerario.Cliente.PersonaFisica != null)
                {
                    dataGridView2.Rows.Add(
                    itinerario.PresupuestosList.NroSeguimiento,
                    itinerario.PresupuestosList.Productos, //ver qué traer de productos, quisiera traer el string que se guarda en el json
                    itinerario.Cliente.PersonaFisica[0].Nombre,
                    "",
                    itinerario.Cliente.PersonaFisica[0].DNI,
                    "",
                    itinerario.Cliente.MedioPago,
                    itinerario.PresupuestosList.Total, //ver como acceder al total que esta siendo calculado
                    "Persona Fisica"
                    );
                }
                else if (itinerario.Cliente.PersonaJuridica != null)
                {
                    dataGridView2.Rows.Add(
                    itinerario.PresupuestosList.NroSeguimiento,
                    itinerario.PresupuestosList.Productos,
                    "",
                    itinerario.Cliente.PersonaJuridica[0].RazonSocial,
                    "",
                    itinerario.Cliente.PersonaJuridica[0].CUIT,
                    itinerario.Cliente.MedioPago,
                    itinerario.PresupuestosList.Total,
                    "Persona Juridica"
                    );
                }
                
                                    
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarRes_Click(object sender, EventArgs e)
        {
            nroseguimiento = textBox1.Text;

            itinerariosFiltrados = ModuloItinerario.ListaItinerarioReserva(nroseguimiento);

            
            Console.WriteLine(itinerariosFiltrados);
            if (itinerariosFiltrados.Count > 0)
            {
                RellenarTablaReserva(itinerariosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontraron Reservas para ese Nro de Seguimiento");
            }
        }

        private void RellenarTablaReserva(List<ItinerarioEnt> itinerariosFiltrados)
        {
            dataGridView3.Rows.Clear();


            foreach (var itinerario in itinerariosFiltrados)
            {
                if (itinerario.Cliente.PersonaFisica != null)
                {
                    dataGridView3.Rows.Add(
                    itinerario.PresupuestosList.NroSeguimiento,
                    itinerario.PresupuestosList.Productos,
                    "Persona Fisica",
                    itinerario.Cliente.PersonaFisica[0].Nombre,
                    "",
                    
                    itinerario.Cliente.MedioPago,
                    itinerario.PresupuestosList.Total, 
                    itinerario.EstadoPago
                    );
                }
                else if (itinerario.Cliente.PersonaJuridica != null)
                {
                    dataGridView2.Rows.Add(
                    itinerario.PresupuestosList.NroSeguimiento,
                    itinerario.PresupuestosList.Productos,
                    "Persona Juridica",
                    "",
                    itinerario.Cliente.PersonaJuridica[0].RazonSocial,
                    
                    itinerario.Cliente.MedioPago,
                    itinerario.PresupuestosList.Total,
                    itinerario.EstadoPago
                    
                    );
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  groupBox1.Visible = true;
            IngresoClientes ingresoClientes = new IngresoClientes();
            ingresoClientes.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
           // MessageBox.Show("Se reserva el presupuesto y se piden más datos relativos al cliente");
        }

        private ItinerarioEnt itinerario;
        private void button5_Click(object sender, EventArgs e) //muestra form pasajeros
        {
            Form pasajerosform = new IngresoPasajeros(itinerario);
            pasajerosform.Show();
            
            //groupBox3.Visible = true;

            //MessageBox.Show("Se reserva la prereserva (datos ya cargados)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirma reserva");
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
            if (selectedItinerario != null)
            {
                Form IngresoPasajeros = new IngresoPasajeros(selectedItinerario);
                IngresoPasajeros.ShowDialog();
            }
                        
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

        private ItinerarioEnt selectedItinerario;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected Itinerario object from the selected row
            selectedItinerario = dataGridView2.Rows[e.RowIndex].DataBoundItem as ItinerarioEnt;
        }

        




        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    Form loginform = new Login();
        //    loginform.Show();
        //    this.Hide();
        //}
    }
}
