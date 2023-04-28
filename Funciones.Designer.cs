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
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tituloFunciones = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // button2
            // 
            button2.Location = new Point(654, 259);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Comprar entradas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(596, 259);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
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
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(label2);
            Controls.Add(tituloFunciones);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(VOLVER);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Funciones";
            Text = "Funciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}