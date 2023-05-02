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
            label1.Text = miCine.nombreLogueado();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t1();
        }



        private void mostarClientes_Click(object sender, EventArgs e)
        {
            refreshData();
        }


        //private void btnMostrar_Click(object sender, EventArgs e)
        //{

        //}



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

                dataGridView1.Rows.Add(new string[] { miCine.Logueado.nombre, f.pelicula.nombre, f.miSala.ubicacion, f.fecha.ToString() });
            }
        }




        //private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
        //    boxPelicula.Text = dataGridView1[1, e.RowIndex].Value.ToString();
        //    boxSala.Text = dataGridView1[2, e.RowIndex].Value.ToString();
        //    boxFecha.Value = Convert.ToDateTime(dataGridView1[3, e.RowIndex].Value.ToString());
        //    boxCosto.Text = dataGridView1[4, e.RowIndex].Value.ToString();
        //    selectedFuncion = int.Parse(boxId.Text);
        //}





        public delegate void ListComprasToCliente();


        /*       foreach (Funcion u in miCine.Logueado.misFunciones)
               {
                   dataGridView1.Rows.Add(new string[] { u.id.ToString() });
               }
           }
       }*/


        // public delegate void ListComprasToCliente();


    }
}