using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP1_GrupoB.Login;

namespace TP1_GrupoB
{
    public partial class Registro : Form
    {
        private Cine miCine;
        public TRegistro transferencia;


        public Registro(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registrarse_Click(object sender, EventArgs e)
        {

            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string dni = textDni.Text;
            string mail = textMail.Text;
            string contrasenia = textContrasenia.Text;
            bool isBloqueado = false;
            bool isAdmin = false;


            if (nombre != null && nombre != "" && apellido != null && apellido != "" && mail != null &&
                mail != "" && dni != null && dni != "" && contrasenia != null && contrasenia != ""
                && isBloqueado == false && isAdmin == false)
            {

                miCine.agregarUsuario(dni, nombre, apellido, mail, contrasenia, isAdmin);
                this.transferencia();
                MessageBox.Show("Usuario registrado con éxito");

            }
            else
            {
                MessageBox.Show("No fue posible registrarse");
            }



        }

        public delegate void TRegistro();




    }
}
