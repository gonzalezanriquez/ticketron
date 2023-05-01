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
        public SalasToAdmin t1;
        private int selectedSala;

        public Salas(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
            label1.Text = miCine.nombreLogueado();
            selectedSala = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.t1();
        }



        private void botonMostrarSalas_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedSala = -1;
        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Sala s in miCine.obtenerSalas())
            {
                dataGridView1.Rows.Add(new string[] { s.id.ToString(), s.ubicacion, s.capacidad.ToString() });
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            boxUbicacion.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            boxCapacidad.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            selectedSala = int.Parse(boxId.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (boxUbicacion.Text == "" || boxCapacidad.Text == "" || boxUbicacion.Text == null || boxCapacidad.Text == null)
            {
                MessageBox.Show("Debe rellenar los datos para agregar al usuario", "Ticketron");
            }
            else if (miCine.agregarSala(boxUbicacion.Text, int.Parse(boxCapacidad.Text)))
            {
                MessageBox.Show("Agregado con exito", "Ticketron");
            }
            else
                MessageBox.Show("Problemas al agregar", "Ticketron");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedSala != -1)
            {
                if (miCine.modificarSala(selectedSala,boxUbicacion.Text,int.Parse(boxCapacidad.Text)))
                {
                    MessageBox.Show("Sala Modificada con Exito", "Ticketron");
                }
                else
                    MessageBox.Show("La Sala no se pudo modificar", "Ticketron");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar alguna sala", "Ticketron");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedSala != -1)
            {
                if (miCine.eliminarUsuario(selectedSala))
                {
                    MessageBox.Show("Sala Eliminada con exito");
                }
                else
                    MessageBox.Show("La sala No se pudo ser eliminada.");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un Sala");
            }

        }
    }
    public delegate void SalasToAdmin();
}

