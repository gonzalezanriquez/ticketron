namespace TP1_GrupoB
{
    partial class Peliculas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Sinopsis = new DataGridViewTextBoxColumn();
            Poster = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            tituloUsuarios = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            label = new Label();
            label3 = new Label();
            boxId = new TextBox();
            boxPoster = new TextBox();
            boxSinopsis = new TextBox();
            boxNombre = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label8 = new Label();
            boxDuracion = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Sinopsis, Poster, Duracion });
            dataGridView1.Location = new Point(24, 330);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(970, 303);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // id
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Nombre
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Sinopsis
            // 
            Sinopsis.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Sinopsis.DefaultCellStyle = dataGridViewCellStyle3;
            Sinopsis.HeaderText = "Sinopsis";
            Sinopsis.Name = "Sinopsis";
            Sinopsis.ReadOnly = true;
            Sinopsis.Width = 75;
            // 
            // Poster
            // 
            Poster.HeaderText = "Poster";
            Poster.Name = "Poster";
            Poster.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Location = new Point(24, 289);
            button1.Name = "button1";
            button1.Size = new Size(233, 35);
            button1.TabIndex = 1;
            button1.Text = "MOSTRAR PELICULAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(761, 244);
            button2.Name = "button2";
            button2.Size = new Size(233, 35);
            button2.TabIndex = 2;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 59);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 9;
            label2.Text = "Usuario Actual:";
            // 
            // tituloUsuarios
            // 
            tituloUsuarios.AutoSize = true;
            tituloUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUsuarios.Location = new Point(24, 25);
            tituloUsuarios.Name = "tituloUsuarios";
            tituloUsuarios.Size = new Size(194, 25);
            tituloUsuarios.TabIndex = 8;
            tituloUsuarios.Text = "SECCION PELICULAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 118);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 35;
            label6.Text = "Sinopsis";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(78, 150);
            label.Name = "label";
            label.Size = new Size(37, 15);
            label.TabIndex = 33;
            label.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 118);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 32;
            label3.Text = "ID";
            // 
            // boxId
            // 
            boxId.BackColor = SystemColors.Menu;
            boxId.Enabled = false;
            boxId.Location = new Point(167, 110);
            boxId.Name = "boxId";
            boxId.Size = new Size(32, 23);
            boxId.TabIndex = 31;
            // 
            // boxPoster
            // 
            boxPoster.Location = new Point(167, 197);
            boxPoster.Name = "boxPoster";
            boxPoster.Size = new Size(158, 23);
            boxPoster.TabIndex = 29;
            // 
            // boxSinopsis
            // 
            boxSinopsis.Location = new Point(438, 110);
            boxSinopsis.Multiline = true;
            boxSinopsis.Name = "boxSinopsis";
            boxSinopsis.Size = new Size(192, 110);
            boxSinopsis.TabIndex = 28;
            // 
            // boxNombre
            // 
            boxNombre.Location = new Point(167, 139);
            boxNombre.Name = "boxNombre";
            boxNombre.Size = new Size(158, 23);
            boxNombre.TabIndex = 26;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(438, 244);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 23);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(290, 244);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 23);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(144, 244);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 23);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 205);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 37;
            label8.Text = "Poster";
            // 
            // boxDuracion
            // 
            boxDuracion.Location = new Point(167, 168);
            boxDuracion.Name = "boxDuracion";
            boxDuracion.Size = new Size(158, 23);
            boxDuracion.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 176);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 34;
            label5.Text = "Duracion";
            // 
            // Peliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(boxId);
            Controls.Add(boxPoster);
            Controls.Add(boxSinopsis);
            Controls.Add(boxDuracion);
            Controls.Add(boxNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(tituloUsuarios);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Peliculas";
            Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label tituloUsuarios;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Label label;
        private Label label3;
        private TextBox boxId;
        private TextBox boxPoster;
        private TextBox boxSinopsis;
        private TextBox boxNombre;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label8;
        private TextBox boxDuracion;
        private Label label5;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Sinopsis;
        private DataGridViewTextBoxColumn Poster;
        private DataGridViewTextBoxColumn Duracion;
    }
}