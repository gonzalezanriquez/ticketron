namespace TP1_GrupoB
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            pictureBox1 = new PictureBox();
            btnUsuarios = new Button();
            btnFunciones = new Button();
            btnPeliculas = new Button();
            btnSalas = new Button();
            tituloBienvenida = new Label();
            btnCerrarSesion = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(466, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.IndianRed;
            btnUsuarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(130, 237);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(249, 43);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "GESTION USUARIOS";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnFunciones
            // 
            btnFunciones.BackColor = Color.Orange;
            btnFunciones.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFunciones.Location = new Point(130, 390);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(249, 43);
            btnFunciones.TabIndex = 3;
            btnFunciones.Text = "GESTION FUNCIONES";
            btnFunciones.UseVisualStyleBackColor = false;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // btnPeliculas
            // 
            btnPeliculas.BackColor = SystemColors.ActiveCaption;
            btnPeliculas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculas.Location = new Point(130, 286);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(249, 43);
            btnPeliculas.TabIndex = 4;
            btnPeliculas.Text = "GESTION PELICULAS";
            btnPeliculas.UseVisualStyleBackColor = false;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // btnSalas
            // 
            btnSalas.BackColor = Color.DarkSeaGreen;
            btnSalas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalas.Location = new Point(130, 341);
            btnSalas.Name = "btnSalas";
            btnSalas.Size = new Size(249, 43);
            btnSalas.TabIndex = 5;
            btnSalas.Text = "GESTION SALAS";
            btnSalas.UseVisualStyleBackColor = false;
            btnSalas.Click += btnSalas_Click;
            // 
            // tituloBienvenida
            // 
            tituloBienvenida.AutoSize = true;
            tituloBienvenida.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloBienvenida.Location = new Point(37, 38);
            tituloBienvenida.Name = "tituloBienvenida";
            tituloBienvenida.Size = new Size(255, 25);
            tituloBienvenida.TabIndex = 6;
            tituloBienvenida.Text = "SECCION ADMINISTRADOR";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.DimGray;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.Location = new Point(787, 577);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(145, 43);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "CERRAR SESION";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DimGray;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(561, 577);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 43);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(btnVolver);
            Controls.Add(btnCerrarSesion);
            Controls.Add(tituloBienvenida);
            Controls.Add(btnSalas);
            Controls.Add(btnPeliculas);
            Controls.Add(btnFunciones);
            Controls.Add(btnUsuarios);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Administrador";
            Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label tituloBienvenida;
        private Button btnCerrarSesion;
        private Button btnUsuarios;
        private Button btnFunciones;
        private Button btnPeliculas;
        private Button btnSalas;
        private Button btnVolver;
    }
}