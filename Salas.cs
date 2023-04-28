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
    public partial class Salas : Form
    {

        private Cine miCine;
        public Salas_Bienvenida transferencia4;

        public Salas(Cine cine)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.transferencia4();
        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Sala s in miCine.obtenerSalas())
            {

                dataGridView1.Rows.Add(new string[] { s.id.ToString(), s.ubicacion, s.capacidad.ToString() });

            }
        }


    }
    public delegate void Salas_Bienvenida();
}

