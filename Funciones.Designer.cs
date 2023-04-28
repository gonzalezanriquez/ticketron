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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // VOLVER
            // 
            VOLVER.Location = new Point(12, 12);
            VOLVER.Name = "VOLVER";
            VOLVER.Size = new Size(75, 23);
            VOLVER.TabIndex = 0;
            VOLVER.Text = "VOLVER";
            VOLVER.UseVisualStyleBackColor = true;
            VOLVER.Click += volver_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, CantClientes, Costo, Fecha, Pelicula, Sala });
            dataGridView1.Location = new Point(12, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(645, 162);
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
            button1.Location = new Point(658, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Mostrar funciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 185);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Comprar entradas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 214);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(VOLVER);
            Name = "Funciones";
            Text = "Funciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
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
    }
}