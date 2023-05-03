using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP1_GrupoB
{
    public partial class Funciones : Form
    {
        public Cine miCine;
        public FuncionesToAdmin t1;
        private int selectedFuncion;
        public List<Usuario> usuarios;
        public Salas sala;



        public Funciones(Cine cine)
        {

            InitializeComponent();
            miCine = cine;
            selectedFuncion = -1;
            label1.Text = miCine.nombreLogueado();

        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
           
            
            dataGridView1.Rows.Clear();

           

            foreach (Funcion f in miCine.obtenerFuncion())
            {
                if (f.fecha>=DateTime.Now)
                {
                    dataGridView1.Rows.Add(new string[] { f.id.ToString(), f.pelicula.nombre.ToString(), f.miSala.ubicacion.ToString(), f.fecha.ToString(), f.costo.ToString(), f.cantClientes.ToString() });
                }
              

              
            }
        }




        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            boxPelicula.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            boxSala.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            boxFecha.Value = Convert.ToDateTime(dataGridView1[3, e.RowIndex].Value.ToString());

            boxCosto.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            selectedFuncion = int.Parse(boxId.Text);
            var clientes = dataGridView1[5, e.RowIndex].Value.ToString();

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (boxPelicula.Text == "" || boxSala.Text == "" || boxFecha.Text == "" || boxCosto.Text == "" ||
                boxPelicula.Text == null || boxSala.Text == null || boxFecha.Text == "" || boxCosto == null)
            {
                MessageBox.Show("Todos los campos deben estar completos", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else

            if (miCine.agregarFuncion(boxSala.Text, boxPelicula.Text, DateTime.Parse(boxFecha.Text), int.Parse(boxCosto.Text)))
            {
                MessageBox.Show("Funcion Agregada de manera Exitosa", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Se proujo un problema al intentar agreagar la Funcion", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {
                if (miCine.modificaFuncion(selectedFuncion, boxSala.Text, boxPelicula.Text, DateTime.Parse(boxFecha.Text), int.Parse(boxCosto.Text)))
                {
                    MessageBox.Show("Funcion Modificada con exito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("La Funcion no se pudo modificar", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una Funcion", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {
                if (miCine.eliminarFunciones(selectedFuncion))
                {
                    MessageBox.Show("Funcion eliminada con exito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("La Funcion no se pudo eliminar", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una Funcion", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t1();
        }

        private void Funciones_Load(object sender, EventArgs e)
        {

            refreshData();
            foreach (Sala salas in miCine.obtenerSalas())
            {
                boxSala.Items.Add(salas.ubicacion);
            }

            foreach (Pelicula pelis in miCine.obtenerPeliculas())
            {
                boxPelicula.Items.Add(pelis.nombre);
            }
        }

        public delegate void FuncionesToAdmin();
    }

}