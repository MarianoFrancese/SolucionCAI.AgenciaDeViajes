namespace SolucionCAI.AgenciaDeViajes
{
    partial class Reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            button1 = new Button();
            buscarPres = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ProductosPres = new DataGridViewTextBoxColumn();
            Column29 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            button11 = new Button();
            button12 = new Button();
            label5 = new Label();
            buscarPrere = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            nrosegPre = new DataGridViewTextBoxColumn();
            ProductosPre = new DataGridViewTextBoxColumn();
            TCPre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TotalPre = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            buscarRes = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            NSegReserva = new DataGridViewTextBoxColumn();
            ProductoReserva = new DataGridViewTextBoxColumn();
            TipoCliente = new DataGridViewTextBoxColumn();
            MedioPago = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            EstadoPago = new DataGridViewTextBoxColumn();
            button8 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(16, 40);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 597);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(buscarPres);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(1026, 564);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Presupuestos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(198, 311);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(386, 121);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confirmación";
            groupBox1.Visible = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(294, 83);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 2;
            button4.Text = "Confirmar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(211, 83);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 1;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 39);
            label2.Name = "label2";
            label2.Size = new Size(294, 28);
            label2.TabIndex = 0;
            label2.Text = "¿Desea generar una Pre-reserva?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(409, 507);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(151, 45);
            button1.TabIndex = 11;
            button1.Text = "Prereservar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buscarPres
            // 
            buscarPres.BackColor = Color.FromArgb(255, 128, 0);
            buscarPres.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarPres.ForeColor = Color.White;
            buscarPres.Location = new Point(289, 16);
            buscarPres.Margin = new Padding(5, 4, 5, 4);
            buscarPres.Name = "buscarPres";
            buscarPres.Size = new Size(101, 36);
            buscarPres.TabIndex = 10;
            buscarPres.Text = "Buscar";
            buscarPres.UseVisualStyleBackColor = false;
            buscarPres.Click += buscarPres_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(127, 16);
            textBox7.Margin = new Padding(5, 4, 5, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(132, 27);
            textBox7.TabIndex = 4;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 20);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 3;
            label7.Text = "Nro Seguimiento";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, ProductosPres, Column29 });
            dataGridView1.Location = new Point(5, 61);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1016, 437);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "NroSeguimiento";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ProductosPres
            // 
            ProductosPres.HeaderText = "Productos";
            ProductosPres.MinimumWidth = 6;
            ProductosPres.Name = "ProductosPres";
            ProductosPres.ReadOnly = true;
            // 
            // Column29
            // 
            Column29.HeaderText = "Total Presupuesto";
            Column29.MinimumWidth = 6;
            Column29.Name = "Column29";
            Column29.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(buscarPrere);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5, 4, 5, 4);
            tabPage2.Size = new Size(1026, 564);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Prereservas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(317, 300);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(386, 121);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Confirmación";
            groupBox3.Visible = false;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(301, 83);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(80, 31);
            button11.TabIndex = 2;
            button11.Text = "Confirmar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(218, 83);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(75, 31);
            button12.TabIndex = 1;
            button12.Text = "Cancelar";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 39);
            label5.Name = "label5";
            label5.Size = new Size(262, 28);
            label5.TabIndex = 0;
            label5.Text = "¿Desea generar una Reserva?";
            // 
            // buscarPrere
            // 
            buscarPrere.BackColor = Color.FromArgb(255, 128, 0);
            buscarPrere.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarPrere.ForeColor = Color.White;
            buscarPrere.Location = new Point(286, 17);
            buscarPrere.Margin = new Padding(5, 4, 5, 4);
            buscarPrere.Name = "buscarPrere";
            buscarPrere.Size = new Size(101, 36);
            buscarPrere.TabIndex = 14;
            buscarPrere.Text = "Buscar";
            buscarPrere.UseVisualStyleBackColor = false;
            buscarPrere.Click += buscarPrere_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.OrangeRed;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(415, 505);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(130, 47);
            button5.TabIndex = 12;
            button5.Text = "Reservar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(123, 17);
            textBox4.Margin = new Padding(5, 4, 5, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 27);
            textBox4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 21);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 2;
            label4.Text = "Nro Seguimiento";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nrosegPre, ProductosPre, TCPre, dataGridViewTextBoxColumn1, TotalPre });
            dataGridView2.Location = new Point(5, 61);
            dataGridView2.Margin = new Padding(5, 4, 5, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1016, 436);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // nrosegPre
            // 
            nrosegPre.HeaderText = "NroSeguimiento";
            nrosegPre.MinimumWidth = 6;
            nrosegPre.Name = "nrosegPre";
            nrosegPre.ReadOnly = true;
            // 
            // ProductosPre
            // 
            ProductosPre.HeaderText = "Productos";
            ProductosPre.MinimumWidth = 6;
            ProductosPre.Name = "ProductosPre";
            ProductosPre.ReadOnly = true;
            // 
            // TCPre
            // 
            TCPre.HeaderText = "Cliente";
            TCPre.MinimumWidth = 6;
            TCPre.Name = "TCPre";
            TCPre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Medio de Pago";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TotalPre
            // 
            TotalPre.HeaderText = "Total Itinerario";
            TotalPre.MinimumWidth = 6;
            TotalPre.Name = "TotalPre";
            TotalPre.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buscarRes);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(5, 4, 5, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(5, 4, 5, 4);
            tabPage3.Size = new Size(1026, 564);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reservas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buscarRes
            // 
            buscarRes.BackColor = Color.FromArgb(255, 128, 0);
            buscarRes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarRes.ForeColor = Color.White;
            buscarRes.Location = new Point(261, 17);
            buscarRes.Margin = new Padding(5, 4, 5, 4);
            buscarRes.Name = "buscarRes";
            buscarRes.Size = new Size(101, 36);
            buscarRes.TabIndex = 17;
            buscarRes.Text = "Buscar";
            buscarRes.UseVisualStyleBackColor = false;
            buscarRes.Click += buscarRes_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.OrangeRed;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(405, 505);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(141, 48);
            button6.TabIndex = 13;
            button6.Text = "Confirmar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 17);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "NroReserva";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { NSegReserva, ProductoReserva, TipoCliente, MedioPago, Total, EstadoPago });
            dataGridView3.Location = new Point(5, 61);
            dataGridView3.Margin = new Padding(5, 4, 5, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1016, 436);
            dataGridView3.TabIndex = 0;
            // 
            // NSegReserva
            // 
            NSegReserva.HeaderText = "Nro Seguimiento";
            NSegReserva.MinimumWidth = 6;
            NSegReserva.Name = "NSegReserva";
            NSegReserva.ReadOnly = true;
            // 
            // ProductoReserva
            // 
            ProductoReserva.HeaderText = "Productos";
            ProductoReserva.MinimumWidth = 6;
            ProductoReserva.Name = "ProductoReserva";
            ProductoReserva.ReadOnly = true;
            // 
            // TipoCliente
            // 
            TipoCliente.HeaderText = "Cliente";
            TipoCliente.MinimumWidth = 6;
            TipoCliente.Name = "TipoCliente";
            TipoCliente.ReadOnly = true;
            // 
            // MedioPago
            // 
            MedioPago.HeaderText = "Medio De Pago";
            MedioPago.MinimumWidth = 6;
            MedioPago.Name = "MedioPago";
            MedioPago.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total Itinerario";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // EstadoPago
            // 
            EstadoPago.HeaderText = "EstadoPago";
            EstadoPago.MinimumWidth = 6;
            EstadoPago.Name = "EstadoPago";
            EstadoPago.ReadOnly = true;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 0);
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(21, 645);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 32;
            button8.Text = "Volver";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 687);
            Controls.Add(button8);
            Controls.Add(tabControl1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Reserva";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private TextBox textBox1;
        private Label label1;
        private Label label7;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox7;
        private Button buscarPres;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button buscarPrere;
        private Button buscarRes;
        private Button button8;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Label label2;
        private GroupBox groupBox3;
        private Button button11;
        private Button button12;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ProductosPres;
        private DataGridViewTextBoxColumn Column29;
        private DataGridViewTextBoxColumn nrosegPre;
        private DataGridViewTextBoxColumn ProductosPre;
        private DataGridViewTextBoxColumn TCPre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TotalPre;
        private DataGridViewTextBoxColumn NSegReserva;
        private DataGridViewTextBoxColumn ProductoReserva;
        private DataGridViewTextBoxColumn TipoCliente;
        private DataGridViewTextBoxColumn MedioPago;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn EstadoPago;
    }
}

