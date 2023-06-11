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
        private void buscarPrere_Click(object sender, EventArgs e)
        {
            nroseguimiento = textBox4.Text;

            itinerariosFiltrados = ModuloItinerario.ListaItinerario(nroseguimiento);
            
            RellenarTablaPre(itinerariosFiltrados);

        }
        private void RellenarTablaPre(List<ItinerarioEnt> itinerariosFiltrados)
        {
            dataGridView2.Rows.Clear();
             
            
            foreach (var itinerario in itinerariosFiltrados)
            {
                if (itinerario.Cliente[0].PersonaFisica != null)
                {
                    dataGridView2.Rows.Add(
                    itinerario.PresupuestosList[0].NroSeguimiento,
                    itinerario.PresupuestosList[0].Productos, //ver qué traer de productos, quisiera traer el string que se guarda en el json
                    itinerario.Cliente[0].PersonaFisica[0].Nombre,
                    "",
                    itinerario.Cliente[0].PersonaFisica[0].DNI,
                    "",
                    itinerario.MedioPago,
                    itinerario.PresupuestosList[0].Total, //ver como acceder al total que esta siendo calculado
                    "Persona Fisica"
                    );
                }
                else
                {
                    dataGridView2.Rows.Add(
                    itinerario.PresupuestosList[0].NroSeguimiento,
                    itinerario.PresupuestosList[0].Productos,
                    "",
                    itinerario.Cliente[0].PersonaJuridica[0].RazonSocial,
                    "",
                    itinerario.Cliente[0].PersonaJuridica[0].CUIT,
                    itinerario.MedioPago,
                    itinerario.PresupuestosList[0].Total,
                    "Persona Juridica"
                    );
                }
                
                                    
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            
            //MessageBox.Show("Se reserva la prereserva (datos ya cargados)");
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
