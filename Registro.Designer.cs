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
            Registrarse = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNombre = new TextBox();
            textMail = new TextBox();
            textContrasenia = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Registrarse
            // 
            Registrarse.Location = new Point(345, 328);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(112, 34);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Registrarse";
            Registrarse.UseVisualStyleBackColor = true;
            Registrarse.Click += Registrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 63);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 63);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 181);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 3;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(646, 63);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 4;
            label4.Text = "Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 181);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 5;
            label5.Text = "Contraseña";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(65, 101);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(150, 31);
            textNombre.TabIndex = 7;
            // 
            // textMail
            // 
            textMail.Location = new Point(589, 101);
            textMail.Name = "textMail";
            textMail.Size = new Size(150, 31);
            textMail.TabIndex = 8;
            // 
            // textContrasenia
            // 
            textContrasenia.Location = new Point(589, 221);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.Size = new Size(150, 31);
            textContrasenia.TabIndex = 9;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(325, 101);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(150, 31);
            textApellido.TabIndex = 10;
            // 
            // textDni
            // 
            textDni.Location = new Point(325, 221);
            textDni.Name = "textDni";
            textDni.Size = new Size(150, 31);
            textDni.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(63, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Administrador";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textContrasenia);
            Controls.Add(textMail);
            Controls.Add(textNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Registrarse);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Registrarse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNombre;
        private TextBox textMail;
        private TextBox textContrasenia;
        private TextBox textApellido;
        private TextBox textDni;
        private CheckBox checkBox1;
    }
}