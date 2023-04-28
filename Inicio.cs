using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GrupoB
{
    public partial class Inicio : Form
    {
        public Bienvenida_a_Inicio transf1;

        private Cine miCine;
        public Inicio(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            tituloInicio.Text = "Hola, " + miCine.nombreLogueado() + ". Ticketron te da la Bienvenida";
        }




        public delegate void Bienvenida_a_Inicio();

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Usuario usu in miCine.obtenerUsuarios())
            {

                if (usu.isAdmin)
                {
                    this.transf1();
                    break;
                }
                else
                {
                    MessageBox.Show("Lamentablemente no puedes acceder. Necesitas ser Administrador" , "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                
            }


           
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
