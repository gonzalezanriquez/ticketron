namespace TP1_GrupoB
{
    partial class ListCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCompras));
            btnVolver = new Button();

            dataGridView1 = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColCosto = new DataGridViewTextBoxColumn();
            ColClientes = new DataGridViewTextBoxColumn();
            mostarClientes = new Button();

            pictureBox1 = new PictureBox();
            btnMostrarCompras = new Button();
            label2 = new Label();
            tituloUsuarios = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idUsuario = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            isAdmin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 

            btnVolver.Location = new Point(675, 47);

            btnVolver.Location = new Point(758, 270);

            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(233, 35);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;

            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColPelicula, ColSala, ColFecha, ColCosto, ColClientes });
            dataGridView1.Location = new Point(161, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(672, 92);
            dataGridView1.TabIndex = 2;
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
            // 
            // mostarClientes
            // 
            mostarClientes.Location = new Point(264, 155);
            mostarClientes.Name = "mostarClientes";
            mostarClientes.Size = new Size(75, 23);
            mostarClientes.TabIndex = 3;
            mostarClientes.Text = "VOLVER";
            mostarClientes.UseVisualStyleBackColor = true;
            mostarClientes.Click += mostarClientes_Click;

            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(758, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnMostrarCompras
            // 
            btnMostrarCompras.AutoSize = true;
            btnMostrarCompras.BackColor = Color.Orange;
            btnMostrarCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarCompras.Location = new Point(29, 270);
            btnMostrarCompras.Name = "btnMostrarCompras";
            btnMostrarCompras.Size = new Size(233, 35);
            btnMostrarCompras.TabIndex = 7;
            btnMostrarCompras.Text = "MOSTRAR COMPRAS";
            btnMostrarCompras.UseVisualStyleBackColor = false;
            btnMostrarCompras.Click += btnMostrarCompras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 73);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 11;
            label2.Text = "Usuario Actual:";
            // 
            // tituloUsuarios
            // 
            tituloUsuarios.AutoSize = true;
            tituloUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUsuarios.Location = new Point(39, 39);
            tituloUsuarios.Name = "tituloUsuarios";
            tituloUsuarios.Size = new Size(290, 25);
            tituloUsuarios.TabIndex = 10;
            tituloUsuarios.Text = "SECCION HISTORIAL COMPRAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 73);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idUsuario, dni, nombre, apellido, mail, password, isAdmin });
            dataGridView1.Location = new Point(29, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 309);
            dataGridView1.TabIndex = 12;
            // 
            // idUsuario
            // 
            idUsuario.Frozen = true;
            idUsuario.HeaderText = "Id";
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Visible = false;
            // 
            // dni
            // 
            dni.Frozen = true;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.Frozen = true;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // mail
            // 
            mail.Frozen = true;
            mail.HeaderText = "Mail";
            mail.Name = "mail";
            // 
            // password
            // 
            password.Frozen = true;
            password.HeaderText = "Contraseña";
            password.Name = "password";
            // 
            // isAdmin
            // 
            isAdmin.Frozen = true;
            isAdmin.HeaderText = "Administrador";
            isAdmin.Name = "isAdmin";
            isAdmin.ReadOnly = true;
            isAdmin.Resizable = DataGridViewTriState.True;

            // 
            // ListCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1006, 537);
            Controls.Add(mostarClientes);
            Controls.Add(dataGridView1);

            ClientSize = new Size(1022, 662);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(tituloUsuarios);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrarCompras);

            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCompras";
            Text = "ListCompras";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColCosto;
        private DataGridViewTextBoxColumn ColClientes;
        private Button mostarClientes;

        private PictureBox pictureBox1;
        private Button btnMostrarCompras;
        private Label label2;
        private Label tituloUsuarios;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn isAdmin;

    }
}