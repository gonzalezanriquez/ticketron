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
            pictureBox1 = new PictureBox();
            btnCompras = new Button();
            label2 = new Label();
            label1 = new Label();
            btnVolver = new Button();
            btnBuyTickets = new Button();
            btnPerfil = new Button();
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
            btnVolver.Location = new Point(744, 500);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(173, 35);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuyTickets
            // 
            btnBuyTickets.BackColor = Color.DarkRed;
            btnBuyTickets.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuyTickets.ForeColor = SystemColors.ControlLightLight;
            btnBuyTickets.Location = new Point(106, 273);
            btnBuyTickets.Name = "btnBuyTickets";
            btnBuyTickets.Size = new Size(233, 35);
            btnBuyTickets.TabIndex = 20;
            btnBuyTickets.Text = "SACA TU ENTRADA";
            btnBuyTickets.UseVisualStyleBackColor = false;
            btnBuyTickets.Click += btnBuyTickets_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.SteelBlue;
            btnPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerfil.Location = new Point(106, 395);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(233, 35);
            btnPerfil.TabIndex = 21;
            btnPerfil.Text = "CONSULTA TU PERFIL";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 623);
            Controls.Add(btnPerfil);
            Controls.Add(btnBuyTickets);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tituloClientes);
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
        private PictureBox pictureBox1;
        private Button btnCompras;
        private Label label2;
        private Label label1;
        private Button btnVolver;
        private Button btnBuyTickets;
        private Button btnPerfil;
    }
}