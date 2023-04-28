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
        private Cine miCine;
        public Funciones_Bienvenida transferencia2;

        public Funciones(Cine cine)
        {

            InitializeComponent();
            miCine = cine;


        }
        // NumericUpDown para contar la cantidad de entradas a comprar (VALOR EN DECIMAL CASTEAR EN INT)
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        //Region cargar lista en la tabla
        #region


        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {

            dataGridView1.Rows.Clear();

            foreach (Funcion f in miCine.obtenerFuncion())
            {

                dataGridView1.Rows.Add(new string[] { f.id.ToString(), f.cantClientes.ToString(), f.costo.ToString(), f.fecha.ToString(), f.miSala.ubicacion, f.pelicula.nombre });

            }
        }

        #endregion

        // Boton de volver
        #region
        private void volver_button_Click(object sender, EventArgs e)
        {
            this.transferencia2();
        }
        #endregion



        private void button2_Click(object sender, EventArgs e)
        {
            miCine.comprarEntrada(miCine.Logueado, numericUpDown1.Value);
        }

        #region Tabla
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1[0, e.RowIndex].Value.ToString();
            string dni = dataGridView1[1, e.RowIndex].Value.ToString();
            string nombre = dataGridView1[2, e.RowIndex].Value.ToString();
            string apellido = dataGridView1[3, e.RowIndex].Value.ToString();
            string mail = dataGridView1[4, e.RowIndex].Value.ToString();
            string contrasenia = dataGridView1[5, e.RowIndex].Value.ToString();

        }
        #endregion

        public delegate void Funciones_Bienvenida();

    }

}

