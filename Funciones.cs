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
        public Funciones_Inicio transferencia2;
        private int selectedFuncion;
        public Mensajes msj;
        public List<Usuario> usuarios;
        public Salas sala;
      


        public Funciones(Cine cine)
        {

            InitializeComponent();
            miCine = cine;
            selectedFuncion = -1;
            label1.Text = miCine.nombreLogueado();


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
                dataGridView1.Rows.Add(new string[] { f.id.ToString(), f.pelicula.nombre.ToString(), f.miSala.ubicacion.ToString(), f.fecha.ToString(), f.costo.ToString(), f.cantClientes.ToString(), });

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
            boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            boxPelicula.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            boxSala.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            boxFecha.Value = DateTime.Parse(dataGridView1[3, e.RowIndex].Value.ToString());
            selectedFuncion = int.Parse(boxId.Text);
            boxCosto.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            //boxCantClientes= dataGridView1[5, e.RowIndex].Value.ToString();

        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (boxPelicula.Text == "" || boxSala.Text == "" || boxFecha.Text==""||boxCosto.Text==""||
                boxPelicula.Text == null || boxSala.Text == null || boxFecha.Text == "" || boxCosto == null )
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
                    MessageBox.Show("Modificado con exito");
                }
                else
                    MessageBox.Show("No se pudo modificar");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un usuario");
            }
        }



        private void Funciones_Load(object sender, EventArgs e)
        {
            foreach (Sala salas in miCine.obtenerSalas())
            {
             boxSala.Items.Add(salas.ubicacion);
            }

            foreach (Pelicula pelis in miCine.obtenerPeliculas())
            {
                boxPelicula.Items.Add(pelis.nombre);
            }
        }

        public delegate void Funciones_Inicio();

    }

}

