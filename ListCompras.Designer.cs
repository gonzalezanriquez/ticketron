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
            pictureBox1 = new PictureBox();
            btnMostrarCompras = new Button();
            label2 = new Label();
            tituloUsuarios = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label = new Label();
            label3 = new Label();
            boxId = new TextBox();
            btnDevolver = new Button();
            boxMonto = new TextBox();
            ColID = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColCosto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(758, 270);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(233, 35);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColPelicula, ColSala, ColFecha, ColCosto });
            dataGridView1.Location = new Point(29, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(942, 205);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(96, 161);
            label.Name = "label";
            label.Size = new Size(119, 15);
            label.TabIndex = 43;
            label.Text = "MONTO A DEVOLVER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 132);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 42;
            label3.Text = "ID";
            // 
            // boxId
            // 
            boxId.BackColor = SystemColors.Menu;
            boxId.Enabled = false;
            boxId.Location = new Point(221, 124);
            boxId.Name = "boxId";
            boxId.Size = new Size(168, 23);
            boxId.TabIndex = 41;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(221, 200);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(168, 23);
            btnDevolver.TabIndex = 44;
            btnDevolver.Text = "DEVOLVER ENTRADA/AS";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // boxMonto
            // 
            boxMonto.Location = new Point(221, 153);
            boxMonto.Name = "boxMonto";
            boxMonto.Size = new Size(168, 23);
            boxMonto.TabIndex = 38;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 8;
            ColID.Name = "ColID";
            ColID.Visible = false;
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
            ColCosto.HeaderText = "Monto";
            ColCosto.MinimumWidth = 8;
            ColCosto.Name = "ColCosto";
            ColCosto.Width = 80;
            // 
            // ListCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 660);
            Controls.Add(btnDevolver);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(boxId);
            Controls.Add(boxMonto);
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
            Load += ListCompras_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;

        private DataGridView dataGridView1;

        private PictureBox pictureBox1;
        private Button btnMostrarCompras;
        private Label label2;
        private Label tituloUsuarios;
        private Label label1;
        private Label label;
        private Label label3;
        private TextBox boxId;
        private Button btnDevolver;
        private TextBox boxMonto;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColCosto;
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