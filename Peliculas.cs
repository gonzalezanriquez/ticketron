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
    public partial class Peliculas : Form
    {
        private Cine miCine;
        public Peliculas_Bienvenida transferencia3;

        public Peliculas(Cine cine)
        {
            InitializeComponent();
            miCine = cine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();

        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Pelicula p in miCine.obtenerPeliculas())
            {

                dataGridView1.Rows.Add(new string[] { p.id.ToString(), p.nombre, p.sinopsis, p.poster, p.duracion.ToString() });

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.transferencia3();
        }

        public delegate void Peliculas_Bienvenida();
    }


}
