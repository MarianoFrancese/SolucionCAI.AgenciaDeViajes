namespace SolucionCAI.AgenciaDeViajes
{
    partial class Presupuesto
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
            comboBox6 = new ComboBox();
            label12 = new Label();
            numericUpDown2 = new NumericUpDown();
            label11 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox5 = new ComboBox();
            BuscarHosp = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dataGridView3 = new DataGridView();
            CodHotel = new DataGridViewTextBoxColumn();
            Column22 = new DataGridViewTextBoxColumn();
            CodCiudad = new DataGridViewTextBoxColumn();
            Column31 = new DataGridViewTextBoxColumn();
            Column32 = new DataGridViewTextBoxColumn();
            Column24 = new DataGridViewTextBoxColumn();
            Column25 = new DataGridViewTextBoxColumn();
            Column26 = new DataGridViewTextBoxColumn();
            Column28 = new DataGridViewTextBoxColumn();
            TarifaEstadia = new DataGridViewTextBoxColumn();
            TipoAdulto = new DataGridViewTextBoxColumn();
            TipoMenor = new DataGridViewTextBoxColumn();
            TipoInfante = new DataGridViewTextBoxColumn();
            Column30 = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            comboBox4 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label4 = new Label();
            label21 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            FechaPartida = new DataGridViewTextBoxColumn();
            FechaArribo = new DataGridViewTextBoxColumn();
            TiempoVuelo = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            cantPasajero = new DataGridViewTextBoxColumn();
            TipoPasajero = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Tarifa = new DataGridViewTextBoxColumn();
            disponibilidadVuelo = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewButtonColumn();
            dataGridView2 = new DataGridView();
            Column14 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            TotalProducto = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewButtonColumn();
            textBox5 = new TextBox();
            label5 = new Label();
            label9 = new Label();
            button1 = new Button();
            label13 = new Label();
            textBox11 = new TextBox();
            button4 = new Button();
            groupBox3 = new GroupBox();
            button11 = new Button();
            button12 = new Button();
            label14 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 14);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(883, 257);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox6);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dateTimePicker3);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(comboBox5);
            tabPage1.Controls.Add(BuscarHosp);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(875, 229);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hospedaje";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Standard", "Intermedia", "Deluxe" });
            comboBox6.Location = new Point(597, 40);
            comboBox6.Margin = new Padding(4, 3, 4, 3);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(104, 23);
            comboBox6.TabIndex = 37;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(602, 16);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(93, 15);
            label12.TabIndex = 36;
            label12.Text = "Tipo Habitacion";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(491, 40);
            numericUpDown2.Margin = new Padding(4, 3, 4, 3);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(63, 23);
            numericUpDown2.TabIndex = 35;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(471, 17);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 15);
            label11.TabIndex = 34;
            label11.Text = "Cant Huespedes";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(271, 36);
            dateTimePicker3.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker3.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker3.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(101, 23);
            dateTimePicker3.TabIndex = 33;
            dateTimePicker3.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(149, 37);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(101, 23);
            dateTimePicker2.TabIndex = 32;
            dateTimePicker2.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged_1;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "BUE", "PAR", "MAD", "MIA", "ROM", "SCL" });
            comboBox5.Location = new Point(12, 36);
            comboBox5.Margin = new Padding(4, 3, 4, 3);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(104, 23);
            comboBox5.TabIndex = 31;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // BuscarHosp
            // 
            BuscarHosp.BackColor = Color.FromArgb(255, 128, 0);
            BuscarHosp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarHosp.ForeColor = Color.White;
            BuscarHosp.Location = new Point(757, 30);
            BuscarHosp.Margin = new Padding(4, 3, 4, 3);
            BuscarHosp.Name = "BuscarHosp";
            BuscarHosp.Size = new Size(88, 27);
            BuscarHosp.TabIndex = 16;
            BuscarHosp.Text = "Buscar";
            BuscarHosp.UseVisualStyleBackColor = false;
            BuscarHosp.Click += BuscarHosp_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(279, 14);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 12;
            label8.Text = "Fecha Salida";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(152, 14);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 11;
            label7.Text = "Fecha Entrada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 14);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Ciudad";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { CodHotel, Column22, CodCiudad, Column31, Column32, Column24, Column25, Column26, Column28, TarifaEstadia, TipoAdulto, TipoMenor, TipoInfante, Column30 });
            dataGridView3.Location = new Point(0, 90);
            dataGridView3.Margin = new Padding(4, 3, 4, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 82;
            dataGridView3.Size = new Size(874, 137);
            dataGridView3.TabIndex = 0;
            // 
            // CodHotel
            // 
            CodHotel.HeaderText = "Código Hotel";
            CodHotel.MinimumWidth = 10;
            CodHotel.Name = "CodHotel";
            CodHotel.Width = 200;
            // 
            // Column22
            // 
            Column22.HeaderText = "Nombre";
            Column22.MinimumWidth = 10;
            Column22.Name = "Column22";
            Column22.Width = 200;
            // 
            // CodCiudad
            // 
            CodCiudad.HeaderText = "Ciudad";
            CodCiudad.MinimumWidth = 10;
            CodCiudad.Name = "CodCiudad";
            CodCiudad.Width = 200;
            // 
            // Column31
            // 
            Column31.HeaderText = "Fecha Entrada";
            Column31.MinimumWidth = 10;
            Column31.Name = "Column31";
            Column31.Width = 200;
            // 
            // Column32
            // 
            Column32.HeaderText = "Fecha Salida";
            Column32.MinimumWidth = 10;
            Column32.Name = "Column32";
            Column32.Width = 200;
            // 
            // Column24
            // 
            Column24.HeaderText = "Dirección";
            Column24.MinimumWidth = 10;
            Column24.Name = "Column24";
            Column24.Width = 200;
            // 
            // Column25
            // 
            Column25.HeaderText = "Calificación";
            Column25.MinimumWidth = 10;
            Column25.Name = "Column25";
            Column25.Width = 200;
            // 
            // Column26
            // 
            Column26.HeaderText = "Tipo Habitación";
            Column26.MinimumWidth = 10;
            Column26.Name = "Column26";
            Column26.Width = 200;
            // 
            // Column28
            // 
            Column28.HeaderText = "Capacidad";
            Column28.MinimumWidth = 10;
            Column28.Name = "Column28";
            Column28.Width = 200;
            // 
            // TarifaEstadia
            // 
            TarifaEstadia.HeaderText = "Tarifa Estadia";
            TarifaEstadia.MinimumWidth = 10;
            TarifaEstadia.Name = "TarifaEstadia";
            TarifaEstadia.Width = 200;
            // 
            // TipoAdulto
            // 
            TipoAdulto.HeaderText = "Adultos";
            TipoAdulto.MinimumWidth = 10;
            TipoAdulto.Name = "TipoAdulto";
            TipoAdulto.Resizable = DataGridViewTriState.True;
            TipoAdulto.SortMode = DataGridViewColumnSortMode.NotSortable;
            TipoAdulto.Width = 200;
            // 
            // TipoMenor
            // 
            TipoMenor.HeaderText = "Menores";
            TipoMenor.MinimumWidth = 10;
            TipoMenor.Name = "TipoMenor";
            TipoMenor.Resizable = DataGridViewTriState.True;
            TipoMenor.SortMode = DataGridViewColumnSortMode.NotSortable;
            TipoMenor.Width = 200;
            // 
            // TipoInfante
            // 
            TipoInfante.HeaderText = "Infantes";
            TipoInfante.MinimumWidth = 10;
            TipoInfante.Name = "TipoInfante";
            TipoInfante.Resizable = DataGridViewTriState.True;
            TipoInfante.SortMode = DataGridViewColumnSortMode.NotSortable;
            TipoInfante.Width = 200;
            // 
            // Column30
            // 
            Column30.HeaderText = "Agregar";
            Column30.MinimumWidth = 10;
            Column30.Name = "Column30";
            Column30.Width = 200;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(875, 229);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vuelos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "BUE", "CDG", "MAD", "MIA", "ROM", "SCL" });
            comboBox4.Location = new Point(156, 29);
            comboBox4.Margin = new Padding(4, 3, 4, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(81, 23);
            comboBox4.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BUE", "CDG", "MAD", "MIA", "ROM", "SCL" });
            comboBox1.Location = new Point(18, 29);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(81, 23);
            comboBox1.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(274, 25);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 32;
            dateTimePicker1.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(462, 25);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 23);
            numericUpDown1.TabIndex = 31;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Economy", "Premium", "Business", "First" });
            comboBox3.Location = new Point(672, 24);
            comboBox3.Margin = new Padding(4, 3, 4, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(78, 23);
            comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "Clase";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Adulto", "Menor", "Infante" });
            comboBox2.Location = new Point(561, 25);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(81, 23);
            comboBox2.TabIndex = 32;
            comboBox2.ValueMember = "Clase";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(690, 7);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 13;
            label10.Text = "Clase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(558, 7);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 11;
            label4.Text = "Tipo Pasajero";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(169, 7);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(50, 15);
            label21.TabIndex = 9;
            label21.Text = "Destino";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(779, 22);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 8;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 7);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(436, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad Pasajeros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Partida";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, FechaPartida, FechaArribo, TiempoVuelo, Column7, cantPasajero, TipoPasajero, Column8, Tarifa, disponibilidadVuelo, Column12 });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.Location = new Point(4, 85);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(867, 138);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "CódigoVuelo";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 101;
            // 
            // Column2
            // 
            Column2.HeaderText = "Origen";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Destino";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
            // 
            // FechaPartida
            // 
            FechaPartida.HeaderText = "Fecha Partida";
            FechaPartida.MinimumWidth = 10;
            FechaPartida.Name = "FechaPartida";
            FechaPartida.ReadOnly = true;
            FechaPartida.Width = 200;
            // 
            // FechaArribo
            // 
            FechaArribo.HeaderText = "Fecha Arribo";
            FechaArribo.MinimumWidth = 10;
            FechaArribo.Name = "FechaArribo";
            FechaArribo.ReadOnly = true;
            FechaArribo.Width = 200;
            // 
            // TiempoVuelo
            // 
            TiempoVuelo.HeaderText = "Tiempo Vuelo";
            TiempoVuelo.MinimumWidth = 10;
            TiempoVuelo.Name = "TiempoVuelo";
            TiempoVuelo.ReadOnly = true;
            TiempoVuelo.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Aerolinea";
            Column7.MinimumWidth = 15;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 200;
            // 
            // cantPasajero
            // 
            cantPasajero.HeaderText = "CantidadPasajeros";
            cantPasajero.MinimumWidth = 6;
            cantPasajero.Name = "cantPasajero";
            cantPasajero.Width = 125;
            // 
            // TipoPasajero
            // 
            TipoPasajero.HeaderText = "Tipo Pasajero";
            TipoPasajero.MinimumWidth = 10;
            TipoPasajero.Name = "TipoPasajero";
            TipoPasajero.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Clase";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 200;
            // 
            // Tarifa
            // 
            Tarifa.HeaderText = "Tarifa";
            Tarifa.MinimumWidth = 10;
            Tarifa.Name = "Tarifa";
            Tarifa.ReadOnly = true;
            Tarifa.Width = 200;
            // 
            // disponibilidadVuelo
            // 
            disponibilidadVuelo.HeaderText = "Disponibilidad";
            disponibilidadVuelo.MinimumWidth = 6;
            disponibilidadVuelo.Name = "disponibilidadVuelo";
            disponibilidadVuelo.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Agregar";
            Column12.MinimumWidth = 10;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 200;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column14, Column16, Column15, Column18, Column19, TotalProducto, Column13 });
            dataGridView2.Location = new Point(14, 331);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(878, 129);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column14
            // 
            Column14.HeaderText = "Producto";
            Column14.MinimumWidth = 10;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 200;
            // 
            // Column16
            // 
            Column16.HeaderText = "PrecioUnitario";
            Column16.MinimumWidth = 10;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 200;
            // 
            // Column15
            // 
            Column15.HeaderText = "Cantidad";
            Column15.MinimumWidth = 10;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 200;
            // 
            // Column18
            // 
            Column18.HeaderText = "SubTotal";
            Column18.MinimumWidth = 10;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            Column18.Width = 200;
            // 
            // Column19
            // 
            Column19.HeaderText = "IVA";
            Column19.MinimumWidth = 10;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 200;
            // 
            // TotalProducto
            // 
            TotalProducto.HeaderText = "Total Producto";
            TotalProducto.MinimumWidth = 10;
            TotalProducto.Name = "TotalProducto";
            TotalProducto.ReadOnly = true;
            TotalProducto.Width = 200;
            // 
            // Column13
            // 
            Column13.HeaderText = "Eliminar";
            Column13.MinimumWidth = 10;
            Column13.Name = "Column13";
            Column13.Width = 200;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(777, 467);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(116, 24);
            textBox5.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(737, 470);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 303);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 18);
            label9.TabIndex = 10;
            label9.Text = "Presupuesto";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(359, 479);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(191, 37);
            button1.TabIndex = 11;
            button1.Text = "Generar Presupuesto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(749, 308);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 27;
            label13.Text = "Nro";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.Control;
            textBox11.Enabled = false;
            textBox11.Location = new Point(784, 305);
            textBox11.Margin = new Padding(4, 3, 4, 3);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(108, 23);
            textBox11.TabIndex = 30;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 488);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 31;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(297, 277);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(338, 91);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Confirmación";
            groupBox3.Visible = false;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(263, 62);
            button11.Name = "button11";
            button11.Size = new Size(70, 23);
            button11.TabIndex = 2;
            button11.Text = "Confirmar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(191, 62);
            button12.Name = "button12";
            button12.Size = new Size(66, 23);
            button12.TabIndex = 1;
            button12.Text = "Cancelar";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(13, 29);
            label14.Name = "label14";
            label14.Size = new Size(236, 21);
            label14.TabIndex = 0;
            label14.Text = "¿Desea generar un Presupuesto?";
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 549);
            Controls.Add(groupBox3);
            Controls.Add(button4);
            Controls.Add(textBox11);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(dataGridView2);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Presupuesto";
            Text = "Presupuesto";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private TextBox textBox5;
        private Label label5;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label label13;
        private TextBox textBox11;
        private Label label21;
        private TabPage tabPage1;
        private ComboBox comboBox5;
        private Button BuscarHosp;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView3;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label10;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label11;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox6;
        private Label label12;
        private Button button4;
        private GroupBox groupBox3;
        private Button button11;
        private Button button12;
        private Label label14;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn FechaPartida;
        private DataGridViewTextBoxColumn FechaArribo;
        private DataGridViewTextBoxColumn TiempoVuelo;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn cantPasajero;
        private DataGridViewTextBoxColumn TipoPasajero;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Tarifa;
        private DataGridViewTextBoxColumn disponibilidadVuelo;
        private DataGridViewButtonColumn Column12;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn TotalProducto;
        private DataGridViewButtonColumn Column13;
        private DataGridViewTextBoxColumn CodHotel;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn CodCiudad;
        private DataGridViewTextBoxColumn Column31;
        private DataGridViewTextBoxColumn Column32;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column26;
        private DataGridViewTextBoxColumn Column28;
        private DataGridViewTextBoxColumn TarifaEstadia;
        private DataGridViewTextBoxColumn TipoAdulto;
        private DataGridViewTextBoxColumn TipoMenor;
        private DataGridViewTextBoxColumn TipoInfante;
        private DataGridViewButtonColumn Column30;
    }
}

