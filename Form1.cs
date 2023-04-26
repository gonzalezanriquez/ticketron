using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP1_GrupoB.Form2;

namespace TP1_GrupoB
{
    public partial class Form1 : Form
    {
        private Cine cine;
        private Login hijoLogin;
        private Usuarios hijoUsuarios;
        private Bienvenida hijoBienvenida;
        private Form2 hijoForm2;

       
        public Form1()
        {
            InitializeComponent();
            cine = new Cine();

            cine.agregarUsuario(32793188, "Leandro", "Gonzalez", "mail", "1234");
            cine.agregarUsuario(32793189, "Camila", "Giudice", "mail2", "3456");
            cine.agregarUsuario(32793180, "Kevin", "Hercog", "mail3", "7890");


            Open_Login();


        }

        private void TLogin()
        {           
            MessageBox.Show("Te damos la bienvenida,  " + cine.nombreLogueado(), "Inicio de Sesion - Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            hijoLogin.Close();

           Open_Bienvenida();
            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.Show();

        }

        private void Bienvenida_a_Usuarios()
        {
            hijoBienvenida.Close();


            Open_Usuarios();           
            hijoUsuarios.transferencia += Usuarios_Bienvendia;
            hijoUsuarios.Show();

        }


        private void Usuarios_Bienvendia()
        {
            hijoUsuarios.Close();
            Open_Bienvenida();
            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.Show();



        }

        /*----------------------------------------------------------------*/
        private void Open_Bienvenida()
        {
            hijoBienvenida = new Bienvenida(cine);
            hijoBienvenida.MdiParent = this;
            hijoBienvenida.Dock = DockStyle.Fill; 
            hijoBienvenida.Show();
        }

        private void Open_Usuarios()
        {
            hijoUsuarios = new Usuarios(cine);
            hijoUsuarios.MdiParent = this;
            hijoUsuarios.Dock = DockStyle.Fill;
      
        }

        private void Open_Login()
        {
            hijoLogin = new Login(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill; /*Para adaptar el contenido dentro de el contenedor */
            hijoLogin.transferencia += TLogin;
            hijoLogin.Show();
        }



        private void Form1_Load(object sender, EventArgs e) {  }
    }
}
