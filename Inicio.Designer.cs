namespace TP1_GrupoB
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnClientes = new Button();
            pictureBox1 = new PictureBox();
            btnAdmin = new Button();
            tituloInicio = new Label();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Orange;
            btnClientes.Location = new Point(641, 334);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(233, 35);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.RosyBrown;
            btnAdmin.Location = new Point(641, 267);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(233, 35);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "ADMINISTRACION";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // tituloInicio
            // 
            tituloInicio.AutoSize = true;
            tituloInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloInicio.Location = new Point(68, 31);
            tituloInicio.Name = "tituloInicio";
            tituloInicio.Size = new Size(0, 25);
            tituloInicio.TabIndex = 10;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.SteelBlue;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.Location = new Point(641, 473);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(233, 35);
            btnCerrarSesion.TabIndex = 11;
            btnCerrarSesion.Text = "CERRAR SESION";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 623);
            Controls.Add(btnCerrarSesion);
            Controls.Add(tituloInicio);
            Controls.Add(btnAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(btnClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private PictureBox pictureBox1;
        private Button btnAdmin;
        private Label tituloInicio;
        private Button btnCerrarSesion;
    }
}