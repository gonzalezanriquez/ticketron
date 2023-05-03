namespace TP1_GrupoB
{
    partial class Salas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salas));
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            Capacidad = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            tituloUsuarios = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            boxId = new TextBox();
            boxCapacidad = new TextBox();
            boxUbicacion = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            botonMostrarSalas = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(759, 242);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(233, 35);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Ubicacion, Capacidad });
            dataGridView1.Location = new Point(30, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 334);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // Ubicacion
            // 
            Ubicacion.HeaderText = "Ubicacion";
            Ubicacion.Name = "Ubicacion";
            // 
            // Capacidad
            // 
            Capacidad.HeaderText = "Capacidad";
            Capacidad.Name = "Capacidad";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(759, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // tituloUsuarios
            // 
            tituloUsuarios.AutoSize = true;
            tituloUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUsuarios.Location = new Point(30, 23);
            tituloUsuarios.Name = "tituloUsuarios";
            tituloUsuarios.Size = new Size(154, 25);
            tituloUsuarios.TabIndex = 5;
            tituloUsuarios.Text = "SECCION SALAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 59);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "Usuario Actual:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 180);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 36;
            label5.Text = "Capacidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 154);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 35;
            label4.Text = "Ubicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 122);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 34;
            label3.Text = "ID";
            // 
            // boxId
            // 
            boxId.BackColor = SystemColors.Menu;
            boxId.Enabled = false;
            boxId.Location = new Point(128, 114);
            boxId.Name = "boxId";
            boxId.Size = new Size(32, 23);
            boxId.TabIndex = 33;
            // 
            // boxCapacidad
            // 
            boxCapacidad.Location = new Point(128, 172);
            boxCapacidad.Name = "boxCapacidad";
            boxCapacidad.Size = new Size(158, 23);
            boxCapacidad.TabIndex = 29;
            // 
            // boxUbicacion
            // 
            boxUbicacion.Location = new Point(128, 143);
            boxUbicacion.Name = "boxUbicacion";
            boxUbicacion.Size = new Size(158, 23);
            boxUbicacion.TabIndex = 28;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(405, 171);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 23);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(405, 141);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 23);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(405, 112);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 23);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // botonMostrarSalas
            // 
            botonMostrarSalas.AutoSize = true;
            botonMostrarSalas.BackColor = Color.Orange;
            botonMostrarSalas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonMostrarSalas.Location = new Point(30, 259);
            botonMostrarSalas.Name = "botonMostrarSalas";
            botonMostrarSalas.Size = new Size(233, 35);
            botonMostrarSalas.TabIndex = 24;
            botonMostrarSalas.Text = "MOSTRAR USUARIOS";
            botonMostrarSalas.UseVisualStyleBackColor = false;
            botonMostrarSalas.Click += botonMostrarSalas_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 23);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Salas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(boxId);
            Controls.Add(boxCapacidad);
            Controls.Add(boxUbicacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(botonMostrarSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tituloUsuarios);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salas";
            Text = "Salas";
            Load += Salas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label tituloUsuarios;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox boxId;
        private TextBox boxCapacidad;
        private TextBox boxUbicacion;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button botonMostrarSalas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn Capacidad;
        private Button btnCancel;
    }
}