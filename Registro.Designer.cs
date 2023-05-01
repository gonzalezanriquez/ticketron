namespace TP1_GrupoB
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            titulo = new Label();
            btnRegister = new Button();
            labelUsuario = new TextBox();
            mail = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(167, 104);
            titulo.Name = "titulo";
            titulo.Size = new Size(273, 25);
            titulo.TabIndex = 2;
            titulo.Text = "REGISTRAR NUEVO USUARIO";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkRed;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(91, 495);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(203, 37);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "ACEPTAR";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.Location = new Point(91, 212);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(203, 23);
            labelUsuario.TabIndex = 10;
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Location = new Point(91, 180);
            mail.Name = "mail";
            mail.Size = new Size(68, 21);
            mail.TabIndex = 9;
            mail.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 379);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 347);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 11;
            label1.Text = "DNI";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 265);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 13;
            label2.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(326, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(326, 180);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 15;
            label3.Text = "Fecha de Nacimiento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(326, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(326, 265);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 17;
            label4.Text = "Correo Electronico";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(326, 379);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 23);
            textBox5.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(326, 347);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 19;
            label5.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(326, 495);
            button1.Name = "button1";
            button1.Size = new Size(203, 37);
            button1.TabIndex = 21;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(249, 443);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Es Administrador";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(labelUsuario);
            Controls.Add(mail);
            Controls.Add(btnRegister);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button btnRegister;
        private TextBox labelUsuario;
        private Label mail;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}