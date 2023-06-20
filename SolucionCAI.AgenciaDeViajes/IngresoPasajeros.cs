using SolucionCAI.AgenciaDeViajes.Archivos;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolucionCAI.AgenciaDeViajes
{
    public partial class IngresoPasajeros : Form
    {
        private ItinerarioEnt itinerario;
        List<PasajeroEnt> pasajeros = new List<PasajeroEnt>();
        public IngresoPasajeros(ItinerarioEnt selectedItinerario)
        {
            InitializeComponent();
            this.itinerario = selectedItinerario;
        }

        class TarifaComboItem
        {
            public TarifaEnt Tarifa { get; set; }
            public string Descripcion { get; set; }
        }

        class PasajeroListItem
        {
            public string Descripcion { get; set; }
            public PasajeroEnt Pasajero { get; set; }
            public TarifaEnt Tarifa { get; set; }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            pasajeros.RemoveAll(x => true);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var mensajerror = itinerario.PuedeReservar();
            if (mensajerror != null)
            {
                MessageBox.Show(mensajerror);
                return;
            }
            else
            {
                List<ItinerarioEnt> itinerariosAGrabar = ModuloItinerario.CargarPasajeros(itinerario);
                ModuloItinerario.GrabarReserva(itinerariosAGrabar);
                MessageBox.Show("Reserva realizada con exito");
                pasajeros.RemoveAll(x => true);
            }

            //realizar la operacion y zaraza.....

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngresoPasajeros_Load(object sender, EventArgs e)
        {
            ProductoPasajero.DisplayMember = nameof(TarifaComboItem.Descripcion);
            listBox1.DisplayMember = nameof(PasajeroListItem.Descripcion);

            //rellenar el combo.
            
            foreach (var linea in itinerario.Presupuesto.Productos)
            {
                if (linea.ProductoV != null)
                {
                    var descripcion = $"{linea.ProductoV.Tarifas[0].Clase} - {linea.ProductoV.Tarifas[0].TipoPasajero} {linea.ProductoV.Aerolinea} {linea.ProductoV.Origen} - {linea.ProductoV.Destino} - {linea.ProductoV.FechaSalida:dd/MM/yy HH:mm} - Uid: {linea.ProductoV.Tarifas[0].Uid}";
                    ProductoPasajero.Items.Add(new TarifaComboItem { Descripcion = descripcion, Tarifa = linea.ProductoV.Tarifas[0] });
                }
            }
                
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var pasajero = ConstruirPasajero();
            if (pasajero == null)
            {
                return;
            }

            var seleccionCombo = ProductoPasajero.SelectedItem as TarifaComboItem; //es null si no hay nada seleccionado
            if (seleccionCombo == null)
            {
                MessageBox.Show("Seleccione una tarifa");
                return;
            }


            foreach (var productoL in itinerario.Presupuesto.Productos)
            {
                if (productoL.ProductoV != null)
                {
                    var productoLinea = itinerario.VueloDeTarifa(seleccionCombo.Tarifa);

                    //la tarifa corresponde a la edad?
                    if (!seleccionCombo.Tarifa.CorrespondeA(pasajero))
                    {
                        MessageBox.Show("La edad no corresponde a la tarifa.");
                        return;
                    }

                    //otras....

                    if (seleccionCombo.Tarifa != null && seleccionCombo.Tarifa.Pasajeros != null && pasajeros.Count == productoLinea.Cantidad)
                    {
                        MessageBox.Show("Ya ha ingresado todos los pasajeros de este vuelo / tarifa"); //sera porque busca distinto de null y como no encuentra no entra
                        return;
                    }
                    else
                    { 
                        pasajeros.Add(pasajero);
                        seleccionCombo.Tarifa.Pasajeros = pasajeros;

                        var descripcion = $"{pasajero.Nombre} {pasajero.Apellido}, DNI: {pasajero.DNI}, Fecha de nacimiento: {pasajero.FechaNac} - {seleccionCombo.Tarifa.Clase} - {seleccionCombo.Tarifa.TipoPasajero} - {productoLinea.ProductoV.Aerolinea} - {productoLinea.ProductoV.Origen} - {productoLinea.ProductoV.Destino} - {productoLinea.ProductoV.FechaSalida:dd/MM/yyyy HH:mm} - Uid: {seleccionCombo.Tarifa.Uid}";
                        listBox1.Items.Add(new PasajeroListItem
                        {
                            Descripcion = descripcion, 
                            Tarifa = seleccionCombo.Tarifa,
                            Pasajero = pasajero
                        });
                    }
                    productoL.ProductoV.Tarifas[0].Pasajeros = pasajeros;
                }
            }

        }
        private PasajeroEnt ConstruirPasajero()
        {

            var validador = new Validaciones();
            string dniP = textBox16.Text;
            string nombreP = textBox14.Text; 
            string apellidoP = textBox15.Text;
            if (!validador.ValidaCampoVacio(nombreP, "Nombre"))
            {

                return null;
            }
            else if (!validador.ValidaTexto(nombreP))
            {
                MessageBox.Show("Nombre no tiene formato válido.");
                return null;
            }
            if (!validador.ValidaCampoVacio(apellidoP, "Apellido"))
            {

                return null;
            }
            else if (!validador.ValidaTexto(apellidoP))
            {
                MessageBox.Show("Apellido no tiene formato válido.");
                return null;
            }

            if (!validador.ValidaCampoVacio(dniP, "DNI"))
            {

                return null;
            }
            else if (!validador.ValidaDNI(dniP))
            {
                return null;
            }




            DateTime selectedDateTime = dateTimePicker1.Value;
            DateOnly dateOnly = new DateOnly(selectedDateTime.Date.Year, selectedDateTime.Date.Month, selectedDateTime.Date.Day);
            return new PasajeroEnt
            {
                Nombre = nombreP,
                Apellido = apellidoP,
                DNI = int.Parse(dniP),
                FechaNac = dateOnly
            };

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void quitarPasajerobtn_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as PasajeroListItem;
            if (item == null)
            {
                MessageBox.Show("Seleccione el pasajero que desea quitar");
                return;
            }

            pasajeros.Remove(item.Pasajero);
            item.Tarifa.Pasajeros.Remove(item.Pasajero);
            listBox1.Items.Remove(item);
        }

    }
}
