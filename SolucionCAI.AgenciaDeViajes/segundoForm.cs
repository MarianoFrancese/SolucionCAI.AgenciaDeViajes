namespace SolucionCAI.AgenciaDeViajes
{
    public partial class segundoForm : Form
    {
        public segundoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form presupuestoForm = new SolucionCAI.AgenciaDeViajes.Presupuesto();
            presupuestoForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form reservasForm = new SolucionCAI.AgenciaDeViajes.Reservas();
            reservasForm.Show();
            this.Hide();

        }
    }
}
