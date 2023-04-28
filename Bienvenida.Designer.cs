namespace TP1_GrupoB
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tituloBienvenida = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(482, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(124, 237);
            button1.Name = "button1";
            button1.Size = new Size(249, 43);
            button1.TabIndex = 2;
            button1.Text = "GESTION USUARIOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(124, 292);
            button2.Name = "button2";
            button2.Size = new Size(249, 43);
            button2.TabIndex = 3;
            button2.Text = "GESTION  FUNCIONES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(124, 348);
            button3.Name = "button3";
            button3.Size = new Size(249, 43);
            button3.TabIndex = 4;
            button3.Text = "GESTION PELICULAS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(124, 403);
            button4.Name = "button4";
            button4.Size = new Size(249, 43);
            button4.TabIndex = 5;
            button4.Text = "GESTION SALAS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 662);
            Controls.Add(tituloBienvenida);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bienvenida";
            Text = "Bienvenida";
            Load += Bienvenida_Load;
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
    }
}