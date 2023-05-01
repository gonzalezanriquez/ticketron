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
        private Cine miCine;
        public ListComprasToCliente t1;

        public ListCompras(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
            label1.Text = miCine.nombreLogueado();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t1();
        }

        private void btnMostrarCompras_Click(object sender, EventArgs e)
        {
            refreshData();
            if (miCine.Logueado.misFunciones.Count==0)
            {
                MessageBox.Show("el Usuario no tiene funciones Asignadas", "Ticketron");
            }

            
        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Funcion u in miCine.Logueado.misFunciones)
            {
                dataGridView1.Rows.Add(new string[] { u.id.ToString() });
            }
        }
    }


        public delegate void ListComprasToCliente();

    }
}
