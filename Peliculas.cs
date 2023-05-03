using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP1_GrupoB
{
    public partial class Peliculas : Form
    {
        private Cine miCine;
        public PeliculasToAdmin t1;
        private int selectedFilm;

        public Peliculas(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            selectedFilm = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedFilm = -1;

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
            this.t1();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1[0, e.RowIndex].Value.ToString() == null)
            {
                MessageBox.Show("Seleccione una Celda con datos", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                boxNombre.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                boxSinopsis.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                boxPoster.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                boxDuracion.Text = dataGridView1[4, e.RowIndex].Value.ToString();

                BoxFlyer.Image = Image.FromFile(@boxPoster.Text);
                disableBtn();
                selectedFilm = int.Parse(boxId.Text);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (boxId.Text == null || boxNombre.Text == null || boxSinopsis.Text == null || boxPoster.Text == null || boxDuracion.Text == null)
            {

                MessageBox.Show("Todos los campos deben estar completos", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refreshData();
                clearBox();
                enableBtn();
            }
            else
            {
                miCine.agregarPelicula(boxNombre.Text, boxSinopsis.Text, boxPoster.Text, int.Parse(boxDuracion.Text));
                MessageBox.Show("Pelicula Agregada con Éxito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedFilm != 1)
            {
                if (miCine.modificarPelicula(selectedFilm, boxNombre.Text, boxSinopsis.Text, boxPoster.Text, int.Parse(boxDuracion.Text)))
                {
                    MessageBox.Show("Pelicula Modificada con Éxito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refreshData();
                    clearBox();
                    enableBtn();
                }
                else
                {
                    MessageBox.Show("Pelicula No se ha podido Modificar", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar a algun Usuario", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedFilm != 1)
            {
                miCine.eliminarPeliculas(int.Parse(boxId.Text));
                MessageBox.Show("Pelicula Eliminada con Éxito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshData();
                clearBox();
                enableBtn();
            }
            else
            {
                MessageBox.Show("Debe seleccionar alguna pelicula para eliminarla", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void clearBox()
        {
            boxId.Clear();
            boxNombre.Clear();
            boxSinopsis.Clear();
            boxPoster.Clear();
            boxDuracion.Clear();
            BoxFlyer.Image = null;
        }

        private void enableBtn()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancel.Visible = false;

        }
        private void disableBtn()
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancel.Visible = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearBox();
            enableBtn();

        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            refreshData();
            enableBtn();
        }

        private void btnFlyer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                BoxFlyer.Image = new Bitmap(open.FileName);
                // image file path  
                boxPoster.Text = open.FileName;
            }
        }
    }

    public delegate void PeliculasToAdmin();


}
