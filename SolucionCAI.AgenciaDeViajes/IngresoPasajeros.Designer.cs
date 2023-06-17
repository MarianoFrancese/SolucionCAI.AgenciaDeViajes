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
            this.btnTerminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProductoPasajero = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.quitarPasajerobtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(203, 434);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(88, 27);
            this.btnTerminar.TabIndex = 0;
            this.btnTerminar.Text = "Salir";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar Pasajeros y Reservar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProductoPasajero);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Location = new System.Drawing.Point(24, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 216);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasajeros";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ProductoPasajero
            // 
            this.ProductoPasajero.FormattingEnabled = true;
            this.ProductoPasajero.Location = new System.Drawing.Point(84, 154);
            this.ProductoPasajero.Name = "ProductoPasajero";
            this.ProductoPasajero.Size = new System.Drawing.Size(457, 23);
            this.ProductoPasajero.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "Asignar a tarifa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar Pasajero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 4, 21, 51, 24, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 84);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 15);
            this.label16.TabIndex = 13;
            this.label16.Text = "Fecha Nacimiento";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "Nombre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 87);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "DNI";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(315, 39);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "Apellido";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(85, 36);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(131, 23);
            this.textBox14.TabIndex = 7;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(386, 36);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(132, 23);
            this.textBox15.TabIndex = 9;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(84, 84);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(132, 23);
            this.textBox16.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(109, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 94);
            this.listBox1.TabIndex = 23;
            // 
            // quitarPasajerobtn
            // 
            this.quitarPasajerobtn.Location = new System.Drawing.Point(497, 376);
            this.quitarPasajerobtn.Name = "quitarPasajerobtn";
            this.quitarPasajerobtn.Size = new System.Drawing.Size(114, 23);
            this.quitarPasajerobtn.TabIndex = 24;
            this.quitarPasajerobtn.Text = "Quitar Pasajero";
            this.quitarPasajerobtn.UseVisualStyleBackColor = true;
            // 
            // IngresoPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 492);
            this.Controls.Add(this.quitarPasajerobtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTerminar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IngresoPasajeros";
            this.Text = "IngresoPasajeros";
            this.Load += new System.EventHandler(this.IngresoPasajeros_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button button2;
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