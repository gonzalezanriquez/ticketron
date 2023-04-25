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
    public partial class Bienvenida : Form
    {
        private Cine miCine;
      
        public TransfDelegado transferencia;
        
        public Bienvenida(Cine cin)
        {
            miCine = cin;
            InitializeComponent();
        }

               
    }

   



    public delegate void TransfDelegado();
    
}
