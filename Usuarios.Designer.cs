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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(613, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(button1);
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
        private Button button1;
    }
}