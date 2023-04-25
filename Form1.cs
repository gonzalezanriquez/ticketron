﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GrupoB
{
    public partial class Form1 : Form
    {
        private Cine cine;
        private Login hijoLogin;
        private Main hijoMain;


        /*constructor*/
        public Form1()
        {
            InitializeComponent();
            cine = new Cine();
            cine.agregarUsuario(32793188, "Leandro", "Gonzalez", "mail", "1234");
            cine.agregarUsuario(32793189, "Camila", "Giudice", "mail2", "3456");
            cine.agregarUsuario(32793180, "Kevin", "Hercog", "mail3", "7890");

            hijoLogin = new Login(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill; /*Para adaptar el contenido dentro de el contenedor */
            hijoLogin.transferencia += TrasnfDelegado;
            hijoLogin.Show();



        }

        private void TrasnfDelegado()
        {
            MessageBox.Show("Te damos la bienvenida,  " + cine.nombreLogueado(), "Inicio de Sesion - Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
            hijoLogin.Close();

            hijoMain=new Main(cine);
            hijoMain.MdiParent = this;  
            hijoMain.Dock = DockStyle.Fill; /*Para adaptar el contenido dentro de el contenedor*/
            hijoMain.Show();
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
