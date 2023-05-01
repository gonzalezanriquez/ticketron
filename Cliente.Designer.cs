namespace TP1_GrupoB
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            tituloClientes = new Label();
            btnComprar = new Button();
            pictureBox1 = new PictureBox();
            btnCompras = new Button();
            label2 = new Label();
            label1 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tituloClientes
            // 
            tituloClientes.AutoSize = true;
            tituloClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloClientes.Location = new Point(40, 36);
            tituloClientes.Name = "tituloClientes";
            tituloClientes.Size = new Size(181, 25);
            tituloClientes.TabIndex = 15;
            tituloClientes.Text = "SECCION CLIENTES";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.DarkRed;
            btnComprar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.ForeColor = SystemColors.ButtonFace;
            btnComprar.Location = new Point(106, 267);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(233, 35);
            btnComprar.TabIndex = 14;
            btnComprar.Text = "SACA TU ENTRADA";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.Orange;
            btnCompras.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.Location = new Point(106, 334);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(233, 35);
            btnCompras.TabIndex = 12;
            btnCompras.Text = "CONSULTA TUS COMPRAS";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 71);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 18;
            label2.Text = "Usuario Actual:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.ForestGreen;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(744, 534);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(173, 35);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 623);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tituloClientes);
            Controls.Add(btnComprar);
            Controls.Add(pictureBox1);
            Controls.Add(btnCompras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label tituloClientes;
        private Button btnComprar;
        private PictureBox pictureBox1;
        private Button btnCompras;
        private Label label2;
        private Label label1;
        private Button btnVolver;
    }
}