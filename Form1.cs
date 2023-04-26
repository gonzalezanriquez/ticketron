using System;
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
        private Usuarios hijoUsuarios;
        private Bienvenida hijoBienvenida;
       
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
            hijoLogin.transferencia += TrasnLogin;
            hijoLogin.Show();


            hijoBienvenida = new Bienvenida(cine);
            hijoBienvenida.MdiParent = this;
            hijoBienvenida.Dock = DockStyle.Fill; /*Para adaptar el contenido dentro de el contenedor */
            hijoBienvenida.transferencia += TrasnfBienvenida;
        

            //hijoUsuarios = new Usuarios(cine);
            //hijoUsuarios.MdiParent = this;
            //hijoUsuarios.Dock = DockStyle.Fill;
            //hijoUsuarios.transferencia += TrasnfUsuarios;  


        }

        private void TrasnLogin()/*le paso este metodo a login para que cierre la ventana y abra BIenvenida*/
        {           
            MessageBox.Show("Te damos la bienvenida,  " + cine.nombreLogueado(), "Inicio de Sesion - Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            hijoLogin.Close();
            hijoBienvenida.Show();   
        }


        private void TrasnfBienvenida()/*le paso este metodo a bienvenida para que cierre la ventana y abra Usuarios*/
        {
            hijoBienvenida.Close();
            hijoUsuarios.Show();
                        
        }

        private void TrasnfUsuarios()/*le paso este metodo a bienvenida para que cierre la ventana y abra Usuarios*/
        {
            hijoUsuarios.Close();
            hijoBienvenida.Show();/*para volver a INICIO*/
        }



        private void Form1_Load(object sender, EventArgs e) {  }
    }
}
