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

        public registroTologin t1;


        public Registro(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string nombre = labelUsuario.Text;
            string apellido = textBox2.Text;
            string dni = textBox1.Text;
            string fechaNaci = textBox3.Text;
            string mail = textBox4.Text;
            string pass = textBox5.Text;
            bool isAdmin = false;

            if (checkBox1.Checked)
            {
                isAdmin = true;
            }

            if (mail != null && mail != "" && pass != null && pass != "" && nombre != null && nombre != "" && apellido != null && apellido != ""
                && dni != null && dni != "")
            {
                miCine.agregarUsuario(dni, nombre, apellido, mail, pass,0.00, isAdmin);
                MessageBox.Show("Usuario registrado con exito.", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.t1();
            }
            else
            {
                miCine.agregarUsuario(dni, nombre, apellido, mail, pass,0.0, isAdmin);
                MessageBox.Show("Debe completar todos los campos", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.t1();
        }


        public delegate void registroTologin();


    }
}