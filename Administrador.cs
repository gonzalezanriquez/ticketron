using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP1_GrupoB.Login;

namespace TP1_GrupoB
{
    public partial class Administrador : Form
    {
        private Cine miCine;
        public AdminToUsuarios t1;
        public AdminToPeliculas t2;
        public AdminToSalas t3;
        public AdminToFunciones t4;
        public AdminToInicio t5;
        public cierreSesion t6;


        public Administrador(Cine cine)
        {
            InitializeComponent();
            miCine = cine;

        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.t1();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.t2();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            this.t3();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            this.t4();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t5();
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.t6();
        }

        public delegate void AdminToUsuarios();
        public delegate void AdminToPeliculas();
        public delegate void AdminToSalas();
        public delegate void AdminToFunciones();
        public delegate void AdminToInicio();
        public delegate void cierreSesion();

    }
}
