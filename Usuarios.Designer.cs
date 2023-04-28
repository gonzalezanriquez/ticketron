namespace TP1_GrupoB
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idUsuario = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            isAdmin = new DataGridViewTextBoxColumn();
            botonMostrarUsuarios = new Button();
            pictureBox1 = new PictureBox();
            tituloUsuarios = new Label();
            label2 = new Label();
            VolverButton = new Button();
            volver_button = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 58);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idUsuario, dni, nombre, apellido, mail, password, isAdmin });
            dataGridView1.Location = new Point(32, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // idUsuario
            // 
            idUsuario.Frozen = true;
            idUsuario.HeaderText = "Id";
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            // 
            // dni
            // 
            dni.Frozen = true;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.Frozen = true;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // mail
            // 
            mail.Frozen = true;
            mail.HeaderText = "Mail";
            mail.Name = "mail";
            // 
            // password
            // 
            password.Frozen = true;
            password.HeaderText = "Contraseña";
            password.Name = "password";
            // 
            // isAdmin
            // 
            isAdmin.Frozen = true;
            isAdmin.HeaderText = "Administrador";
            isAdmin.Name = "isAdmin";
            isAdmin.ReadOnly = true;
            // 
            // botonMostrarUsuarios
            // 
            botonMostrarUsuarios.AutoSize = true;
            botonMostrarUsuarios.BackColor = Color.Orange;
            botonMostrarUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonMostrarUsuarios.Location = new Point(761, 243);
            botonMostrarUsuarios.Name = "botonMostrarUsuarios";
            botonMostrarUsuarios.Size = new Size(233, 35);
            botonMostrarUsuarios.TabIndex = 2;
            botonMostrarUsuarios.Text = "MOSTRAR USUARIOS";
            botonMostrarUsuarios.UseVisualStyleBackColor = false;
            botonMostrarUsuarios.Click += botonMostrarUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tituloUsuarios
            // 
            tituloUsuarios.AutoSize = true;
            tituloUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUsuarios.Location = new Point(32, 24);
            tituloUsuarios.Name = "tituloUsuarios";
            tituloUsuarios.Size = new Size(191, 25);
            tituloUsuarios.TabIndex = 4;
            tituloUsuarios.Text = "SECCION USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Usuario Actual:";
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(0, 0);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(75, 23);
            VolverButton.TabIndex = 0;
            // 
            // volver_button
            // 
            volver_button.Location = new Point(564, 242);
            volver_button.Name = "volver_button";
            volver_button.Size = new Size(75, 23);
            volver_button.TabIndex = 6;
            volver_button.Text = "VOLVER";
            volver_button.UseVisualStyleBackColor = true;
            volver_button.Click += volver_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(551, 97);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 7;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(551, 140);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 8;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(551, 185);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 9;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(153, 242);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(153, 213);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 100);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 17;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 129);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 18;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 163);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 19;
            label5.Text = "NOMBRE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 188);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 20;
            label6.Text = "APELLIDO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 221);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 21;
            label7.Text = "MAIL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 245);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 22;
            label8.Text = "CONTRASEÑA";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(volver_button);
            Controls.Add(label2);
            Controls.Add(tituloUsuarios);
            Controls.Add(pictureBox1);
            Controls.Add(botonMostrarUsuarios);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn password;
        private Button botonMostrarUsuarios;
        private PictureBox pictureBox1;
        private Label tituloUsuarios;
        private Label label2;
        private DataGridViewTextBoxColumn isAdmin;
        private Button VolverButton;
        private Button volver_button;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}