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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1083, 450);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(333, 58);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 8;
            ColID.Name = "ColID";
            ColID.Width = 150;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.MinimumWidth = 8;
            ColPelicula.Name = "ColPelicula";
            ColPelicula.Width = 150;
            // 
            // ColSala
            // 
            ColSala.HeaderText = "Sala";
            ColSala.MinimumWidth = 8;
            ColSala.Name = "ColSala";
            ColSala.Width = 150;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.MinimumWidth = 8;
            ColFecha.Name = "ColFecha";
            ColFecha.Width = 150;
            // 
            // ColCosto
            // 
            ColCosto.HeaderText = "Costo";
            ColCosto.MinimumWidth = 8;
            ColCosto.Name = "ColCosto";
            ColCosto.Width = 150;
            // 
            // ColClientes
            // 
            ColClientes.HeaderText = "Cant Clientes";
            ColClientes.MinimumWidth = 8;
            ColClientes.Name = "ColClientes";
            ColClientes.Width = 150;
            // 
            // mostarClientes
            // 
            mostarClientes.Location = new Point(377, 258);
            mostarClientes.Margin = new Padding(4, 5, 4, 5);
            mostarClientes.Name = "mostarClientes";
            mostarClientes.Size = new Size(107, 38);
            mostarClientes.TabIndex = 3;
            mostarClientes.Text = "VOLVER";
            mostarClientes.UseVisualStyleBackColor = true;
            mostarClientes.Click += mostarClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1083, 65);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnMostrarCompras
            // 
            btnMostrarCompras.AutoSize = true;
            btnMostrarCompras.BackColor = Color.Orange;
            btnMostrarCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarCompras.Location = new Point(41, 450);
            btnMostrarCompras.Margin = new Padding(4, 5, 4, 5);
            btnMostrarCompras.Name = "btnMostrarCompras";
            btnMostrarCompras.Size = new Size(333, 58);
            btnMostrarCompras.TabIndex = 7;
            btnMostrarCompras.Text = "MOSTRAR COMPRAS";
            btnMostrarCompras.UseVisualStyleBackColor = false;
            btnMostrarCompras.Click += btnMostrarCompras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 11;
            label2.Text = "Usuario Actual:";
            // 
            // tituloUsuarios
            // 
            tituloUsuarios.AutoSize = true;
            tituloUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUsuarios.Location = new Point(56, 65);
            tituloUsuarios.Margin = new Padding(4, 0, 4, 0);
            tituloUsuarios.Name = "tituloUsuarios";
            tituloUsuarios.Size = new Size(442, 40);
            tituloUsuarios.TabIndex = 10;
            tituloUsuarios.Text = "SECCION HISTORIAL COMPRAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColPelicula, ColSala, ColFecha, ColCosto, ColClientes });
            dataGridView1.Location = new Point(41, 540);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1048, 153);
            dataGridView1.TabIndex = 2;
            // 
            // ListCompras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 1103);
            Controls.Add(mostarClientes);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(tituloUsuarios);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrarCompras);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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
        /* private DataGridView dataGridView1;
         private DataGridViewTextBoxColumn idUsuario;
         private DataGridViewTextBoxColumn dni;
         private DataGridViewTextBoxColumn nombre;
         private DataGridViewTextBoxColumn apellido;
         private DataGridViewTextBoxColumn mail;
         private DataGridViewTextBoxColumn password;
         private DataGridViewTextBoxColumn isAdmin;*/

    }
}