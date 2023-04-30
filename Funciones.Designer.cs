namespace TP1_GrupoB
{
    partial class Funciones
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funciones));
            VOLVER = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CantClientes = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Pelicula = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            cineBindingSource = new BindingSource(components);
            funcionBindingSource = new BindingSource(components);
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tituloFunciones = new Label();
            label1 = new Label();
            boxFecha = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            boxId = new TextBox();
            boxCosto = new TextBox();
            boxPelicula = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            boxSala = new TextBox();
            label5 = new Label();
            panelEdicion = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // VOLVER
            // 
            VOLVER.BackColor = Color.IndianRed;
            VOLVER.Location = new Point(761, 253);
            VOLVER.Name = "VOLVER";
            VOLVER.Size = new Size(233, 35);
            VOLVER.TabIndex = 0;
            VOLVER.Text = "VOLVER";
            VOLVER.UseVisualStyleBackColor = false;
            VOLVER.Click += volver_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, CantClientes, Costo, Fecha, Pelicula, Sala });
            dataGridView1.Location = new Point(32, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // CantClientes
            // 
            CantClientes.HeaderText = "CantClientes";
            CantClientes.Name = "CantClientes";
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Pelicula
            // 
            Pelicula.HeaderText = "Pelicula";
            Pelicula.Name = "Pelicula";
            // 
            // Sala
            // 
            Sala.HeaderText = "Sala";
            Sala.Name = "Sala";
            // 
            // cineBindingSource
            // 
            cineBindingSource.DataSource = typeof(Cine);
            // 
            // funcionBindingSource
            // 
            funcionBindingSource.DataSource = typeof(Funcion);
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(32, 262);
            button1.Name = "button1";
            button1.Size = new Size(233, 35);
            button1.TabIndex = 2;
            button1.Text = "MOSTRAR FUNCIONES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 68);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 8;
            label2.Text = "Usuario Actual:";
            // 
            // tituloFunciones
            // 
            tituloFunciones.AutoSize = true;
            tituloFunciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloFunciones.Location = new Point(41, 34);
            tituloFunciones.Name = "tituloFunciones";
            tituloFunciones.Size = new Size(203, 25);
            tituloFunciones.TabIndex = 7;
            tituloFunciones.Text = "SECCION FUNCIONES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 68);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // boxFecha
            // 
            boxFecha.Location = new Point(343, 51);
            boxFecha.MaxDate = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            boxFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            boxFecha.Name = "boxFecha";
            boxFecha.Size = new Size(232, 23);
            boxFecha.TabIndex = 9;
            boxFecha.Value = new DateTime(2023, 4, 30, 14, 2, 54, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 88);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 37;
            label7.Text = "Costo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 59);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 36;
            label6.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 62);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 34;
            label4.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 30);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 33;
            label3.Text = "ID";
            // 
            // boxId
            // 
            boxId.BackColor = SystemColors.Menu;
            boxId.Enabled = false;
            boxId.Location = new Point(89, 22);
            boxId.Name = "boxId";
            boxId.Size = new Size(32, 23);
            boxId.TabIndex = 32;
            // 
            // boxCosto
            // 
            boxCosto.Location = new Point(343, 80);
            boxCosto.Name = "boxCosto";
            boxCosto.Size = new Size(232, 23);
            boxCosto.TabIndex = 31;
            // 
            // boxPelicula
            // 
            boxPelicula.Location = new Point(89, 51);
            boxPelicula.Name = "boxPelicula";
            boxPelicula.Size = new Size(158, 23);
            boxPelicula.TabIndex = 27;
            // 
            // button3
            // 
            button3.Location = new Point(478, 125);
            button3.Name = "button3";
            button3.Size = new Size(97, 24);
            button3.TabIndex = 26;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(330, 125);
            button4.Name = "button4";
            button4.Size = new Size(97, 24);
            button4.TabIndex = 25;
            button4.Text = "MODIFICAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(184, 125);
            button5.Name = "button5";
            button5.Size = new Size(97, 24);
            button5.TabIndex = 24;
            button5.Text = "AGREGAR";
            button5.UseVisualStyleBackColor = true;
            // 
            // boxSala
            // 
            boxSala.Location = new Point(89, 80);
            boxSala.Name = "boxSala";
            boxSala.Size = new Size(158, 23);
            boxSala.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 88);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 35;
            label5.Text = "Sala";
            // 
            // panelEdicion
            // 
            panelEdicion.Controls.Add(label3);
            panelEdicion.Controls.Add(boxPelicula);
            panelEdicion.Controls.Add(label7);
            panelEdicion.Controls.Add(boxCosto);
            panelEdicion.Controls.Add(boxFecha);
            panelEdicion.Controls.Add(boxSala);
            panelEdicion.Controls.Add(label6);
            panelEdicion.Controls.Add(boxId);
            panelEdicion.Controls.Add(button5);
            panelEdicion.Controls.Add(button3);
            panelEdicion.Controls.Add(label5);
            panelEdicion.Controls.Add(label4);
            panelEdicion.Controls.Add(button4);
            panelEdicion.Location = new Point(36, 95);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(611, 161);
            panelEdicion.TabIndex = 39;
            // 
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(panelEdicion);
            Controls.Add(label2);
            Controls.Add(tituloFunciones);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(VOLVER);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Funciones";
            Text = "Funciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEdicion.ResumeLayout(false);
            panelEdicion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VOLVER;
        private DataGridView dataGridView1;
        private BindingSource cineBindingSource;
        private BindingSource funcionBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CantClientes;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Fecha;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn Pelicula;
        private DataGridViewTextBoxColumn Sala;
        private PictureBox pictureBox1;
        private Label label2;
        private Label tituloFunciones;
        private Label label1;
        private DateTimePicker boxFecha;
        private CheckBox checkBoxIsAdmin;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox boxId;
        private TextBox boxCosto;
        private TextBox boxContrasenia;
        private TextBox boxApellido;
        private TextBox boxNombre;
        private TextBox boxPelicula;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox boxSala;
        private Label label5;
        private Panel panelEdicion;
    }
}