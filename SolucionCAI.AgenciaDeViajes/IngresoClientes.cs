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

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class IngresoClientes : Form
    {
        public IngresoClientes()
        {
            InitializeComponent();
        }

        private void tipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected option from the ComboBox

            string opcionpersona = tipoCliente.SelectedItem.ToString();

            // Show or hide the relevant GroupBoxes based on the selected option
            if (opcionpersona == "Persona Fisica")
            {
                personaFisica.Visible = true;
                personaJuridica.Visible = false;
                // Set the visibility of other GroupBoxes as needed
            }
            else if (opcionpersona == "Persona Juridica")
            {
                personaFisica.Visible = false;
                personaJuridica.Visible = true;
            }

            else
            {
                // If no specific option is selected, hide all GroupBoxes
                personaFisica.Visible = false;
                personaJuridica.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
