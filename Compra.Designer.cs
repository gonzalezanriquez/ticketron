namespace TP1_GrupoB
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            panelEdicion = new Panel();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            boxId = new TextBox();
            btnComprar = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            tituloFunciones = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnMostrar = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CantClientes = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Pelicula = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            BoxSala = new TextBox();
            boxPelicula = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panelEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelEdicion
            // 
            panelEdicion.Controls.Add(textBox2);
            panelEdicion.Controls.Add(textBox1);
            panelEdicion.Controls.Add(boxPelicula);
            panelEdicion.Controls.Add(BoxSala);
            panelEdicion.Controls.Add(label3);
            panelEdicion.Controls.Add(label7);
            panelEdicion.Controls.Add(label6);
            panelEdicion.Controls.Add(boxId);
            panelEdicion.Controls.Add(btnComprar);
            panelEdicion.Controls.Add(label5);
            panelEdicion.Controls.Add(label4);
            panelEdicion.Location = new Point(33, 90);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(611, 161);
            panelEdicion.TabIndex = 47;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 62);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 37;
            label7.Text = "Costo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 30);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 36;
            label6.Text = "Fecha";
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
            // btnComprar
            // 
            btnComprar.Location = new Point(446, 128);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(97, 24);
            btnComprar.TabIndex = 26;
            btnComprar.Text = "COMPRAR";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 93);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 35;
            label5.Text = "Sala";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 63);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 46;
            label2.Text = "Usuario Actual:";
            // 
            // tituloFunciones
            // 
            tituloFunciones.AutoSize = true;
            tituloFunciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloFunciones.Location = new Point(38, 29);
            tituloFunciones.Name = "tituloFunciones";
            tituloFunciones.Size = new Size(310, 25);
            tituloFunciones.TabIndex = 45;
            tituloFunciones.Text = "SECCION COMPRA DE ENTRADAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 63);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 44;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(758, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.DarkOrange;
            btnMostrar.Location = new Point(29, 257);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(233, 35);
            btnMostrar.TabIndex = 42;
            btnMostrar.Text = "MOSTRAR FUNCIONES";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, CantClientes, Costo, Fecha, Pelicula, Sala });
            dataGridView1.Location = new Point(29, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 334);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
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
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.Location = new Point(758, 248);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(233, 35);
            btnVolver.TabIndex = 40;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // BoxSala
            // 
            BoxSala.BackColor = SystemColors.Menu;
            BoxSala.Enabled = false;
            BoxSala.Location = new Point(89, 85);
            BoxSala.Name = "BoxSala";
            BoxSala.Size = new Size(192, 23);
            BoxSala.TabIndex = 38;
            // 
            // boxPelicula
            // 
            boxPelicula.BackColor = SystemColors.Menu;
            boxPelicula.Enabled = false;
            boxPelicula.Location = new Point(89, 54);
            boxPelicula.Name = "boxPelicula";
            boxPelicula.Size = new Size(192, 23);
            boxPelicula.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Enabled = false;
            textBox1.Location = new Point(351, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Enabled = false;
            textBox2.Location = new Point(351, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 49;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(panelEdicion);
            Controls.Add(label2);
            Controls.Add(tituloFunciones);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compra";
            Text = "Compra";
            panelEdicion.ResumeLayout(false);
            panelEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelEdicion;
        private Label label3;
        private Label label7;
        private TextBox boxCosto;
        private Label label6;
        private TextBox boxId;
        private Button btnAgregar;
        private Button btnComprar;
        private Label label5;
        private Label label4;
        private Button btnModificar;
        private Label label2;
        private Label tituloFunciones;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnMostrar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CantClientes;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Pelicula;
        private DataGridViewTextBoxColumn Sala;
        private Button btnVolver;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox boxPelicula;
        private TextBox BoxSala;
        private ComboBox boxSala;
      //  private ComboBox boxPelicula;
    }
}