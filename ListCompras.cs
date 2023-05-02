using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
            label1.Text = miCine.nombreLogueado() + " Saldo: " + miCine.Logueado.credito;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t1();
        }



        private void mostarClientes_Click(object sender, EventArgs e)
        {
            refreshData();
        }



        private void btnMostrarCompras_Click(object sender, EventArgs e)
        {
            refreshData();
            if (miCine.Logueado.misFunciones.Count == 0)
            {
                MessageBox.Show("el Usuario no tiene funciones Asignadas", "Ticketron");
            }

        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();


            foreach (Funcion f in miCine.Logueado.misFunciones)
            {
                dataGridView1.Rows.Add(new string[] { miCine.Logueado.nombre, f.pelicula.nombre, f.miSala.ubicacion, f.fecha.ToString(), f.costo.ToString() });
            }

        }

        private void ListCompras_Load(object sender, EventArgs e)
        {
            refreshData();
            if (miCine.Logueado.misFunciones.Count == 0)
            {
                MessageBox.Show("el Usuario no tiene funciones Asignadas", "Ticketron");
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            boxMonto.Text = dataGridView1[4, e.RowIndex].Value.ToString();

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            foreach (Funcion f in miCine.Logueado.misFunciones)
            {
                if (f.fecha >= DateTime.Now)
                {
                    miCine.Logueado.credito += f.costo;
                    MessageBox.Show("Monto devuelto de manera correcta.", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //miCine.Logueado.misFunciones.Remove(f);
                }


            }
        }

        public delegate void ListComprasToCliente();



    }
}