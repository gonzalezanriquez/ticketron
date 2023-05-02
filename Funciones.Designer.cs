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
            ID = new DataGridViewTextBoxColumn();
            Pelicula = new DataGridViewTextBoxColumn();

            IDs = new DataGridViewTextBoxColumn();
            Peliculas = new DataGridViewTextBoxColumn();
            Salas = new DataGridViewTextBoxColumn();
            Fechas = new DataGridViewTextBoxColumn();
            Costos = new DataGridViewTextBoxColumn();
            ColID = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();

            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColPeliculas = new DataGridViewTextBoxColumn();
            ColSalas = new DataGridViewTextBoxColumn();

            ColFecha = new DataGridViewTextBoxColumn();
            ColCosto = new DataGridViewTextBoxColumn();
            ColClientes = new DataGridViewTextBoxColumn();
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
            btnVolver.Location = new Point(761, 253);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(233, 35);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColPelicula, ColSala, ColFecha, ColCosto, ColClientes });

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, ColPeliculas, ColSalas, ColFecha, ColCosto, ColClientes });
            dataGridView1.Location = new Point(32, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
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
            btnMostrar.Location = new Point(32, 262);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(233, 35);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "MOSTRAR FUNCIONES";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
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
            boxFecha.CustomFormat = "dd MM yyyy hh:mm:ss";
            boxFecha.Format = DateTimePickerFormat.Custom;
            boxFecha.Location = new Point(343, 51);
            boxFecha.MaxDate = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            boxFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            boxFecha.Name = "boxFecha";
            boxFecha.Size = new Size(232, 23);
            boxFecha.TabIndex = 9;
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
            boxId.Size = new Size(192, 23);
            boxId.TabIndex = 32;
            // 
            // boxCosto
            // 
            boxCosto.Location = new Point(343, 80);
            boxCosto.Name = "boxCosto";
            boxCosto.Size = new Size(232, 23);
            boxCosto.TabIndex = 31;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(478, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 24);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(330, 125);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 24);
            btnModificar.TabIndex = 25;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(184, 125);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 24);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            panelEdicion.Location = new Point(36, 95);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(611, 161);
            panelEdicion.TabIndex = 39;
            // 
            // boxSala
            // 
            boxSala.FormattingEnabled = true;
            boxSala.Location = new Point(89, 83);
            boxSala.Name = "boxSala";
            boxSala.Size = new Size(192, 23);
            boxSala.TabIndex = 39;
            // 
            // boxPelicula
            // 
            boxPelicula.FormattingEnabled = true;
            boxPelicula.Location = new Point(89, 54);
            boxPelicula.Name = "boxPelicula";
            boxPelicula.Size = new Size(192, 23);
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
            // ID
            // 

            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Pelicula
            // 
            Pelicula.HeaderText = "Pelicula";
            Pelicula.Name = "Pelicula";
            // 
            // IDs
            // 
            IDs.HeaderText = "IDs";
            IDs.Name = "IDs";
            // 
            // Peliculas
            // 
            Peliculas.HeaderText = "Peliculas";
            Peliculas.Name = "Peliculas";
            // 
            // Salas
            // 
            Salas.HeaderText = "Salas";
            Salas.Name = "Salas";
            // 
            // Fechas
            // 
            Fechas.HeaderText = "Fechas";
            Fechas.Name = "Fechas";
            // 
            // Costos
            // 
            Costos.HeaderText = "Costos";
            Costos.Name = "Costos";
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            // 
            // ColSala
            // 
            ColSala.HeaderText = "Sala";
            ColSala.Name = "ColSala";
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.Name = "ColFecha";
            // 
            // ColCosto
            // 
            ColCosto.HeaderText = "Costo";
            ColCosto.Name = "ColCosto";
            // 
            // ColClientes
            // 
            ColClientes.HeaderText = "Cant Clientes";
            ColClientes.Name = "ColClientes";

            ID.Frozen = true;
            ID.HeaderText = "id";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Pelicula
            // 
            Pelicula.Frozen = true;
            Pelicula.HeaderText = "Pelicula";
            Pelicula.Name = "Pelicula";
            Pelicula.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Peliculas";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Salas";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fechas";
            Column4.Name = "Column4";
            // 
            // Column1
            // 
            Column1.HeaderText = "Costos";
            Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // ColPeliculas
            // 
            ColPeliculas.Frozen = true;
            ColPeliculas.HeaderText = "Peliculas";
            ColPeliculas.Name = "ColPeliculas";
            ColPeliculas.ReadOnly = true;
            // 
            // ColSalas
            // 
            ColSalas.Frozen = true;
            ColSalas.HeaderText = "Salas";
            ColSalas.Name = "ColSalas";
            ColSalas.ReadOnly = true;
            // 
            // ColFecha
            // 
            ColFecha.Frozen = true;
            ColFecha.HeaderText = "Fecha";
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            // 
            // ColCosto
            // 
            ColCosto.Frozen = true;
            ColCosto.HeaderText = "Costo";
            ColCosto.Name = "ColCosto";
            ColCosto.ReadOnly = true;
            // 
            // ColClientes
            // 
            ColClientes.Frozen = true;
            ColClientes.HeaderText = "Cant Clientes";
            ColClientes.Name = "ColClientes";
            ColClientes.ReadOnly = true;

            // 
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 660);
            Controls.Add(panelEdicion);
            Controls.Add(label2);
            Controls.Add(tituloFunciones);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnMostrar;
        private Button button2;
        private NumericUpDown numericUpDown1;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Pelicula;

        private DataGridViewTextBoxColumn IDs;
        private DataGridViewTextBoxColumn Peliculas;
        private DataGridViewTextBoxColumn Salas;
        private DataGridViewTextBoxColumn Fechas;
        private DataGridViewTextBoxColumn Costos;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColPeliculas;
        private DataGridViewTextBoxColumn ColSalas;

        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColCosto;
        private DataGridViewTextBoxColumn ColClientes;
    }
}