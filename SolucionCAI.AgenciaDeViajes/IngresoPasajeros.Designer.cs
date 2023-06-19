namespace SolucionCAI.AgenciaDeViajes
{
    partial class IngresoPasajeros
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
            btnTerminar = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            ProductoPasajero = new ComboBox();
            label15 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            listBox1 = new ListBox();
            quitarPasajerobtn = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(232, 579);
            btnTerminar.Margin = new Padding(5, 4, 5, 4);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(101, 36);
            btnTerminar.TabIndex = 0;
            btnTerminar.Text = "Salir";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(414, 565);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 61);
            button2.TabIndex = 1;
            button2.Text = "Guardar Pasajeros y Reservar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ProductoPasajero);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(textBox14);
            groupBox3.Controls.Add(textBox15);
            groupBox3.Controls.Add(textBox16);
            groupBox3.Location = new Point(27, 51);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(790, 288);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pasajeros";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // ProductoPasajero
            // 
            ProductoPasajero.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoPasajero.FormattingEnabled = true;
            ProductoPasajero.Location = new Point(96, 205);
            ProductoPasajero.Margin = new Padding(3, 4, 3, 4);
            ProductoPasajero.Name = "ProductoPasajero";
            ProductoPasajero.Size = new Size(522, 28);
            ProductoPasajero.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 181);
            label15.Name = "label15";
            label15.Size = new Size(113, 20);
            label15.TabIndex = 20;
            label15.Text = "Asignar a tarifa:";
            // 
            // button1
            // 
            button1.Location = new Point(654, 249);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 31);
            button1.TabIndex = 19;
            button1.Text = "Agregar Pasajero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(441, 109);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2023, 6, 4, 21, 51, 24, 0);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(315, 112);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(128, 20);
            label16.TabIndex = 13;
            label16.Text = "Fecha Nacimiento";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(30, 52);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(64, 20);
            label17.TabIndex = 13;
            label17.Text = "Nombre";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(45, 116);
            label18.Margin = new Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Size = new Size(35, 20);
            label18.TabIndex = 14;
            label18.Text = "DNI";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(360, 52);
            label20.Margin = new Padding(5, 0, 5, 0);
            label20.Name = "label20";
            label20.Size = new Size(66, 20);
            label20.TabIndex = 15;
            label20.Text = "Apellido";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(97, 48);
            textBox14.Margin = new Padding(5, 4, 5, 4);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(149, 27);
            textBox14.TabIndex = 7;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(441, 48);
            textBox15.Margin = new Padding(5, 4, 5, 4);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(150, 27);
            textBox15.TabIndex = 9;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(96, 112);
            textBox16.Margin = new Padding(5, 4, 5, 4);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(150, 27);
            textBox16.TabIndex = 17;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(125, 368);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(573, 124);
            listBox1.TabIndex = 23;
            // 
            // quitarPasajerobtn
            // 
            quitarPasajerobtn.Location = new Point(568, 501);
            quitarPasajerobtn.Margin = new Padding(3, 4, 3, 4);
            quitarPasajerobtn.Name = "quitarPasajerobtn";
            quitarPasajerobtn.Size = new Size(130, 31);
            quitarPasajerobtn.TabIndex = 24;
            quitarPasajerobtn.Text = "Quitar Pasajero";
            quitarPasajerobtn.UseVisualStyleBackColor = true;
            quitarPasajerobtn.Click += quitarPasajerobtn_Click;
            // 
            // IngresoPasajeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 656);
            Controls.Add(quitarPasajerobtn);
            Controls.Add(listBox1);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(btnTerminar);
            Margin = new Padding(5, 4, 5, 4);
            Name = "IngresoPasajeros";
            Text = "IngresoPasajeros";
            Load += IngresoPasajeros_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerminar;
        private Button button2;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private Button button1;
        private ListBox listBox1;
        private Label label15;
        private ComboBox ProductoPasajero;
        private Button quitarPasajerobtn;
    }
}