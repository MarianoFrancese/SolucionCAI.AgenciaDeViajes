using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SolucionCAI.AgenciaDeViajes.Archivos;
using SolucionCAI.AgenciaDeViajes.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class IngresoClientes : Form
    {
        private string numeroSeguimiento;
        public IngresoClientes(string nroSeguimiento)
        {
            InitializeComponent();
            numeroSeguimiento = nroSeguimiento;
        }

        private void tipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected option from the ComboBox

            string opcionpersona = tipoCliente.SelectedItem.ToString();

            if (opcionpersona == "Persona Fisica")
            {
                personaFisica.Visible = true;
                personaJuridica.Visible = false;
                textBox12.Text = string.Empty;
                textBox11.Text = string.Empty;
                textBox9.Text = string.Empty;
                textBox8.Text = string.Empty;
                comboBox3.Text = string.Empty;
                textBox7.Text = string.Empty;
            }
            else if (opcionpersona == "Persona Juridica")
            {
                personaFisica.Visible = false;
                personaJuridica.Visible = true;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                comboBox2.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
            }
            else
            {
                personaFisica.Visible = false;
                personaJuridica.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void personaJuridica_Enter(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonCliente_Click(object sender, EventArgs e)
        {
            if (tipoCliente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de cliente");
                return;
            }
            else if (tipoCliente.SelectedItem.ToString() == "Persona Fisica")
            {
                if (comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || comboBox2.SelectedItem == null || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Debe completar todos los campos");
                    return;
                }
                else if (comboBox2.SelectedItem != null && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && comboBox2.SelectedItem != null && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    string nombre = textBox1.Text;
                    string apellido = textBox2.Text;
                    string dni = textBox3.Text;
                    string cuil = textBox4.Text;
                    string condFiscal = comboBox2.Text;
                    string telefono = textBox5.Text;
                    string email = textBox6.Text;
                    string medioPago = comboBox1.Text;

                    ClienteEnt cliente = ModuloItinerario.CrearCliente(nombre, apellido, dni, cuil, condFiscal, telefono, email, medioPago);
                    PresupuestoEnt presupuesto = ModuloPresupuesto.TraerPresupuesto(Convert.ToInt32(numeroSeguimiento));
                    ItinerarioEnt prereserva = ModuloItinerario.CrearPrereserva(presupuesto, cliente);
                    ModuloItinerario.GrabarPrereserva(prereserva);
                    this.Close();
                }
            }
            else if (tipoCliente.SelectedItem.ToString() == "Persona Juridica")
            {
                if (comboBox4.SelectedItem ==null || string.IsNullOrWhiteSpace(textBox12.Text) || string.IsNullOrWhiteSpace(textBox11.Text) || string.IsNullOrWhiteSpace(textBox9.Text) || comboBox3.SelectedItem == null || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("Debe completar todos los campos");
                    return;
                }
                else if (comboBox4.SelectedItem != null && !string.IsNullOrWhiteSpace(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) && comboBox3.SelectedItem != null && !string.IsNullOrWhiteSpace(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    string razonSocial = textBox12.Text;
                    string cuit = textBox11.Text;
                    string domicilio = textBox9.Text;
                    string condFiscalE = comboBox3.Text;
                    string telefonoE = textBox8.Text;
                    string emailE = textBox7.Text;
                    string medioPago = comboBox4.Text;

                    ClienteEnt cliente = ModuloItinerario.CrearClienteEmpresa(razonSocial, domicilio, cuit, condFiscalE, telefonoE, emailE, medioPago);
                    PresupuestoEnt presupuesto = ModuloPresupuesto.TraerPresupuesto(Convert.ToInt32(numeroSeguimiento));
                    ItinerarioEnt prereserva = ModuloItinerario.CrearPrereserva(presupuesto, cliente);
                    ModuloItinerario.GrabarPrereserva(prereserva);
                    this.Close();

                }
            }







        }
    }
}
