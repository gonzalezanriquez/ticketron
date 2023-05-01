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
            mail = new Label();
            labelUsuario = new TextBox();
            labelContrasenia = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnRegistrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(614, 199);
            titulo.Name = "titulo";
            titulo.Size = new Size(255, 25);
            titulo.TabIndex = 1;
            titulo.Text = "TE DAMOS LA BIENVENIDA";
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Location = new Point(671, 261);
            mail.Name = "mail";
            mail.Size = new Size(138, 21);
            mail.TabIndex = 2;
            mail.Text = "Correo Electronico";
            // 
            // labelUsuario
            // 
            labelUsuario.Location = new Point(614, 303);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(255, 23);
            labelUsuario.TabIndex = 3;
            // 
            // labelContrasenia
            // 
            labelContrasenia.Location = new Point(614, 387);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(255, 23);
            labelContrasenia.TabIndex = 5;
            labelContrasenia.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(697, 354);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 4;
            label1.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkOrange;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(631, 446);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(106, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(763, 446);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(106, 37);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "REGISTRARSE";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(774, 536);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(75, 23);
            btnRegistrarse.TabIndex = 8;
            btnRegistrarse.Text = "button1";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(labelContrasenia);
            Controls.Add(label1);
            Controls.Add(labelUsuario);
            Controls.Add(mail);
            Controls.Add(titulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN - Te damos la Bienvenida";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label titulo;
        private Label mail;
        private TextBox labelUsuario;
        private TextBox labelContrasenia;
        private Label label1;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnRegistrarse;
    }
}