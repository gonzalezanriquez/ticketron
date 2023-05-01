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
    public partial class Compra : Form
    {
        Cine miCine;
        public CompraToCliente t1;

        public Compra(Cine miCine)
        {
            InitializeComponent();
            this.miCine = miCine;
        }

        public delegate void CompraToCliente();

        private void refreshData()
        {
            dataGridView1.Rows.Clear();
            foreach (Funcion f in miCine.obtenerFuncion())
            {
                dataGridView1.Rows.Add(new string[] { f.id.ToString(), f.pelicula.nombre.ToString(), f.miSala.ubicacion.ToString(), f.fecha.ToString(), f.costo.ToString(), f.cantClientes.ToString() });
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            refreshData();
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            miCine.comprarEntrada(miCine.Logueado, 12, 1);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t1();
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
