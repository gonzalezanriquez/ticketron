using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GrupoB
{
    public partial class ListCompras : Form
    {
        Cine miCine;
        ClienteToListCompras t1;

        public ListCompras(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
        }





        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t1();
        }

        public delegate void ClienteToListCompras();

    }
}
