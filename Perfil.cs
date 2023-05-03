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

namespace TP1_GrupoB
{
    public partial class Perfil : Form
    {
        private Cine miCine;
        public ClienteToPerfil t1;
        private int selectedUser;

        public Perfil(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            label1.Text = miCine.nombreLogueado();

            boxId.Text = miCine.Logueado.id.ToString();
            boxApellido.Text = miCine.Logueado.apellido;
            boxNombre.Text = miCine.Logueado.nombre;
            boxMail.Text = miCine.Logueado.mail;
            boxDni.Text = miCine.Logueado.dni;
            boxContrasenia.Text = miCine.Logueado.contrasenia;
            boxCredito.Text = miCine.Logueado.credito.ToString();
            selectedUser = miCine.Logueado.id;
        }





        public delegate void ClienteToPerfil();

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedUser != -1)
            {
                double newCredito = miCine.Logueado.credito += double.Parse(boxAgregarCredito.Value.ToString());
                if (miCine.modificarUsuario(selectedUser, boxId.Text, boxNombre.Text, boxApellido.Text, boxContrasenia.Text, boxMail.Text, newCredito,checkBoxIsAdmin.Checked))
                {
                  

                    MessageBox.Show("Usuario Modificado con exito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("El usario no pudo ser modificado", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
            }
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.t1();
        }
    }
}
