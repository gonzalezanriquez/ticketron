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
    public partial class ListCompras : Form
    {
        Cine miCine;
        public ListCompras(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
        }
    }
}
