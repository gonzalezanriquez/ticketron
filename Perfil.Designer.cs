namespace TP1_GrupoB
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            volver_button = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            boxId = new TextBox();
            boxMail = new TextBox();
            boxContrasenia = new TextBox();
            boxApellido = new TextBox();
            boxNombre = new TextBox();
            boxDni = new TextBox();
            label2 = new Label();
            tituloUsuarios = new Label();
            label1 = new Label();
            btnModificar = new Button();
            checkBoxIsAdmin = new CheckBox();
            label9 = new Label();
            boxCredito = new TextBox();
            boxAgregarCredito = new NumericUpDown();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxAgregarCredito).BeginInit();
            SuspendLayout();
            // 
            // volver_button
            // 
            volver_button.BackColor = Color.DarkSalmon;
            volver_button.Location = new Point(718, 395);
            volver_button.Name = "volver_button";
            volver_button.Size = new Size(233, 35);
            volver_button.TabIndex = 8;
            volver_button.Text = "VOLVER";
            volver_button.UseVisualStyleBackColor = false;
            volver_button.Click += volver_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(718, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 293);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 34;
            label8.Text = "CONTRASEÑA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 264);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 33;
            label7.Text = "MAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 351);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 32;
            label6.Text = "APELLIDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 322);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 31;
            label5.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 296);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 30;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 264);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 29;
            label3.Text = "ID";
            // 
            // boxId
            // 
            boxId.BackColor = SystemColors.Menu;
            boxId.Enabled = false;
            boxId.Location = new Point(156, 256);
            boxId.Name = "boxId";
            boxId.Size = new Size(32, 23);
            boxId.TabIndex = 28;
            // 
            // boxMail
            // 
            boxMail.Location = new Point(484, 256);
            boxMail.Name = "boxMail";
            boxMail.Size = new Size(158, 23);
            boxMail.TabIndex = 4;
            // 
            // boxContrasenia
            // 
            boxContrasenia.Location = new Point(484, 285);
            boxContrasenia.Name = "boxContrasenia";
            boxContrasenia.Size = new Size(158, 23);
            boxContrasenia.TabIndex = 5;
            // 
            // boxApellido
            // 
            boxApellido.Location = new Point(156, 343);
            boxApellido.Name = "boxApellido";
            boxApellido.Size = new Size(158, 23);
            boxApellido.TabIndex = 3;
            // 
            // boxNombre
            // 
            boxNombre.Location = new Point(156, 314);
            boxNombre.Name = "boxNombre";
            boxNombre.Size = new Size(158, 23);
            boxNombre.TabIndex = 2;
            // 
            // boxDni
            // 
            boxDni.Location = new Point(156, 285);
            boxDni.Name = "boxDni";
            boxDni.Size = new Size(158, 23);
            boxDni.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 75);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 37;
            label2.Text = "Usuario Actual:";
            // 
            // tituloUsuarios
            // 
            tituloUsuarios.AutoSize = true;
            tituloUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUsuarios.Location = new Point(51, 41);
            tituloUsuarios.Name = "tituloUsuarios";
            tituloUsuarios.Size = new Size(245, 25);
            tituloUsuarios.TabIndex = 36;
            tituloUsuarios.Text = "SECCION PERFIL USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 75);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 35;
            label1.Text = "label1";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.MediumTurquoise;
            btnModificar.Location = new Point(312, 461);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(129, 35);
            btnModificar.TabIndex = 38;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.AutoSize = true;
            checkBoxIsAdmin.Location = new Point(86, 404);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(102, 19);
            checkBoxIsAdmin.TabIndex = 7;
            checkBoxIsAdmin.Text = "Administrador";
            checkBoxIsAdmin.UseVisualStyleBackColor = true;
            checkBoxIsAdmin.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 322);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 41;
            label9.Text = "SALDO";
            // 
            // boxCredito
            // 
            boxCredito.BackColor = SystemColors.Menu;
            boxCredito.Enabled = false;
            boxCredito.Location = new Point(484, 314);
            boxCredito.Name = "boxCredito";
            boxCredito.Size = new Size(158, 23);
            boxCredito.TabIndex = 6;
            // 
            // boxAgregarCredito
            // 
            boxAgregarCredito.Location = new Point(484, 345);
            boxAgregarCredito.Name = "boxAgregarCredito";
            boxAgregarCredito.Size = new Size(47, 23);
            boxAgregarCredito.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 350);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 43;
            label10.Text = "AGREGAR CREDITO";
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(label10);
            Controls.Add(boxAgregarCredito);
            Controls.Add(label9);
            Controls.Add(boxCredito);
            Controls.Add(checkBoxIsAdmin);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(tituloUsuarios);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(boxId);
            Controls.Add(boxMail);
            Controls.Add(boxContrasenia);
            Controls.Add(boxApellido);
            Controls.Add(boxNombre);
            Controls.Add(boxDni);
            Controls.Add(volver_button);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Perfil";
            Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxAgregarCredito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button volver_button;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox boxId;
        private TextBox boxMail;
        private TextBox boxContrasenia;
        private TextBox boxApellido;
        private TextBox boxNombre;
        private TextBox boxDni;
        private Label label2;
        private Label tituloUsuarios;
        private Label label1;
        private Button btnModificar;
        private CheckBox checkBoxIsAdmin;
        private Label label9;
        private TextBox boxCredito;
        private NumericUpDown boxAgregarCredito;
        private Label label10;
    }
}