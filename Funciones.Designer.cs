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
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CantClientes = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Pelicula = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            cineBindingSource = new BindingSource(components);
            funcionBindingSource = new BindingSource(components);
            btnMostrar = new Button();
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            panelEdicion = new Panel();
            boxSala = new ComboBox();
            boxPelicula = new ComboBox();
            salasBindingSource1 = new BindingSource(components);
            cineBindingSource1 = new BindingSource(components);
            salasBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.Location = new Point(1087, 422);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(333, 58);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, CantClientes, Costo, Fecha, Pelicula, Sala });
            dataGridView1.Location = new Point(46, 505);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1374, 557);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // CantClientes
            // 
            CantClientes.HeaderText = "CantClientes";
            CantClientes.MinimumWidth = 8;
            CantClientes.Name = "CantClientes";
            CantClientes.Width = 150;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 8;
            Costo.Name = "Costo";
            Costo.Width = 150;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // Pelicula
            // 
            Pelicula.HeaderText = "Pelicula";
            Pelicula.MinimumWidth = 8;
            Pelicula.Name = "Pelicula";
            Pelicula.Width = 150;
            // 
            // Sala
            // 
            Sala.HeaderText = "Sala";
            Sala.MinimumWidth = 8;
            Sala.Name = "Sala";
            Sala.Width = 150;
            // 
            // cineBindingSource
            // 
            cineBindingSource.DataSource = typeof(Cine);
            // 
            // funcionBindingSource
            // 
            funcionBindingSource.DataSource = typeof(Funcion);
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.DarkOrange;
            btnMostrar.Location = new Point(46, 437);
            btnMostrar.Margin = new Padding(4, 5, 4, 5);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(333, 58);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "MOSTRAR FUNCIONES";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1087, 57);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 8;
            label2.Text = "Usuario Actual:";
            // 
            // tituloFunciones
            // 
            tituloFunciones.AutoSize = true;
            tituloFunciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloFunciones.Location = new Point(59, 57);
            tituloFunciones.Margin = new Padding(4, 0, 4, 0);
            tituloFunciones.Name = "tituloFunciones";
            tituloFunciones.Size = new Size(307, 40);
            tituloFunciones.TabIndex = 7;
            tituloFunciones.Text = "SECCION FUNCIONES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // boxFecha
            // 
            boxFecha.CustomFormat = "dd MM yyyy hh:mm:ss";
            boxFecha.Format = DateTimePickerFormat.Custom;

            boxFecha.CustomFormat = "dd MM yyyy hh:mm:ss";
            boxFecha.Location = new Point(490, 85);


            boxFecha.Margin = new Padding(4, 5, 4, 5);
            boxFecha.MaxDate = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            boxFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            boxFecha.Name = "boxFecha";
            boxFecha.Size = new Size(330, 31);
            boxFecha.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 147);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 37;
            label7.Text = "Costo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 98);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 36;
            label6.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 34;
            label4.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 33;
            label3.Text = "ID";
            // 
            // boxId
            // 
            boxId.BackColor = SystemColors.Menu;
            boxId.Enabled = false;
            boxId.Location = new Point(127, 37);
            boxId.Margin = new Padding(4, 5, 4, 5);
            boxId.Name = "boxId";
            boxId.Size = new Size(273, 31);
            boxId.TabIndex = 32;
            // 
            // boxCosto
            // 
            boxCosto.Location = new Point(490, 133);
            boxCosto.Margin = new Padding(4, 5, 4, 5);
            boxCosto.Name = "boxCosto";
            boxCosto.Size = new Size(330, 31);
            boxCosto.TabIndex = 31;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(683, 208);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 40);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(471, 208);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 40);
            btnModificar.TabIndex = 25;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(263, 208);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 40);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 147);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 35;
            label5.Text = "Sala";
            // 
            // panelEdicion
            // 
            panelEdicion.Controls.Add(boxSala);
            panelEdicion.Controls.Add(boxPelicula);
            panelEdicion.Controls.Add(label3);
            panelEdicion.Controls.Add(label7);
            panelEdicion.Controls.Add(boxCosto);
            panelEdicion.Controls.Add(boxFecha);
            panelEdicion.Controls.Add(label6);
            panelEdicion.Controls.Add(boxId);
            panelEdicion.Controls.Add(btnAgregar);
            panelEdicion.Controls.Add(btnEliminar);
            panelEdicion.Controls.Add(label5);
            panelEdicion.Controls.Add(label4);
            panelEdicion.Controls.Add(btnModificar);
            panelEdicion.Location = new Point(51, 158);
            panelEdicion.Margin = new Padding(4, 5, 4, 5);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(873, 268);
            panelEdicion.TabIndex = 39;
            // 
            // boxSala
            // 
            boxSala.FormattingEnabled = true;
            boxSala.Location = new Point(127, 138);
            boxSala.Margin = new Padding(4, 5, 4, 5);
            boxSala.Name = "boxSala";
            boxSala.Size = new Size(273, 33);
            boxSala.TabIndex = 39;
            // 
            // boxPelicula
            // 
            boxPelicula.FormattingEnabled = true;
            boxPelicula.Location = new Point(127, 90);
            boxPelicula.Margin = new Padding(4, 5, 4, 5);
            boxPelicula.Name = "boxPelicula";
            boxPelicula.Size = new Size(273, 33);
            boxPelicula.TabIndex = 38;
            // 
            // salasBindingSource1
            // 
            salasBindingSource1.DataMember = "salas";
            salasBindingSource1.DataSource = cineBindingSource1;
            // 
            // cineBindingSource1
            // 
            cineBindingSource1.DataSource = typeof(Cine);
            // 
            // salasBindingSource
            // 
            salasBindingSource.DataMember = "salas";
            salasBindingSource.DataSource = cineBindingSource1;
            // 
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 1103);
            Controls.Add(panelEdicion);
            Controls.Add(label2);
            Controls.Add(tituloFunciones);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Funciones";
            Text = "Funciones";
            Load += Funciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEdicion.ResumeLayout(false);
            panelEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dataGridView1;
        private BindingSource cineBindingSource;
        private BindingSource funcionBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CantClientes;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnMostrar;
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


        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;

        private Label label5;
        private Panel panelEdicion;
        private BindingSource cineBindingSource1;
        private BindingSource salasBindingSource;
        private BindingSource salasBindingSource1;

        private ComboBox boxSala;
        private ComboBox boxPelicula;
    }
}