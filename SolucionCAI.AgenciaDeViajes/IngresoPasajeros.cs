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

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class IngresoPasajeros : Form
    {
        public IngresoPasajeros()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngresoPasajeros_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected option from the ComboBox
            string opcionpersona = comboBox1.SelectedItem.ToString();

            // Show or hide the relevant GroupBoxes based on the selected option
            if (opcionpersona == "Persona Física")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                // Set the visibility of other GroupBoxes as needed
            }
            else if (opcionpersona == "Persona Jurídica")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                
            }
            
            else
            {
                // If no specific option is selected, hide all GroupBoxes
                groupBox1.Visible = false;
                groupBox2.Visible = false;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string nombrep = textBox14.Text;
            string apellidop = textBox15.Text;
            int dnip = int.Parse(textBox16.Text);
            DateTime fechapick = dateTimePicker1.Value;

            // Format the DateTime value
            string nacimientop = fechapick.ToString("dd-MM-yyyy");

            // Concatenate the values into a single string
            string datopasajero = $"{nombrep} - {apellidop} - {dnip} - {nacimientop}";

            // Add the contact information to the ListBox
            listBox1.Items.Add(datopasajero);

            // Clear the text boxes
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
