using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP1_GrupoB.Login;

namespace TP1_GrupoB
{
    public partial class Form2 : Form
    {
        private Cine miCine;
        public TrasnForm2 transferencia;
        public volverBienvenidaDeForm2 volver;
        public string logueado;


        public Form2(Cine cin)
        {
            InitializeComponent();
            miCine = cin;
            //tituloVentana.Text = miCine.nombreLogueado();

    

        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.volver();

        }
        public delegate void TrasnForm2();
        public delegate void volverBienvenidaDeForm2();
    }
}
