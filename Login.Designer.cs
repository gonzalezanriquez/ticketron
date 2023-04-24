namespace TP1_GrupoB
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            titulo = new Label();
            usuario = new Label();
            labelUsuario = new TextBox();
            labelContrasenia = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(589, 192);
            titulo.Name = "titulo";
            titulo.Size = new Size(255, 25);
            titulo.TabIndex = 1;
            titulo.Text = "TE DAMOS LA BIENVENIDA";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usuario.Location = new Point(686, 250);
            usuario.Name = "usuario";
            usuario.Size = new Size(64, 21);
            usuario.TabIndex = 2;
            usuario.Text = "Usuario";
            // 
            // labelUsuario
            // 
            labelUsuario.Location = new Point(589, 283);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(255, 23);
            labelUsuario.TabIndex = 3;
            // 
            // labelContrasenia
            // 
            labelContrasenia.Location = new Point(589, 367);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(255, 23);
            labelContrasenia.TabIndex = 5;
            labelContrasenia.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(672, 334);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 4;
            label1.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(669, 426);
            button1.Name = "button1";
            button1.Size = new Size(92, 37);
            button1.TabIndex = 6;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(button1);
            Controls.Add(labelContrasenia);
            Controls.Add(label1);
            Controls.Add(labelUsuario);
            Controls.Add(usuario);
            Controls.Add(titulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN -Te damos la Bienvenida";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label titulo;
        private Label usuario;
        private TextBox labelUsuario;
        private TextBox labelContrasenia;
        private Label label1;
        private Button button1;
    }
}