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
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColCosto = new DataGridViewTextBoxColumn();
            ColClientes = new DataGridViewTextBoxColumn();
            mostarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(675, 47);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
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
            // 
            // ListCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 537);
            Controls.Add(mostarClientes);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCompras";
            Text = "ListCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
    }
}