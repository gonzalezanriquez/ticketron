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
        public inicioToAdmin t1;
        public inicioToCliente t2;
        public cierreSesion t3;

        private Cine miCine;
        public Inicio(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            tituloInicio.Text = "Hola, " + miCine.nombreLogueado() + ". Ticketron te da la Bienvenida ";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (miCine.Logueado.isAdmin)
            {
              
                this.t1();
                
            }
            else
            {
             
                MessageBox.Show("Lamentablemente no puedes acceder. Necesitas ser Administrador", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }


          

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.t2();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.t3();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }

    public delegate void inicioToAdmin();
    public delegate void inicioToCliente();
    public delegate void cierreSesion();
}
