namespace TP1_GrupoB
{
    public partial class Usuarios : Form
    {
        private Cine miCine;
        private int selectedUser;
        public Usuarios_Bienvenida transferencia;

        public Usuarios(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            label1.Text = miCine.nombreLogueado();
            selectedUser = -1;

        }



        private void botonMostrarUsuarios_Click(object sender, EventArgs e)
        {

            refreshData();
            selectedUser = -1;
        }

        private void refreshData()
        {

            dataGridView1.Rows.Clear();

            foreach (Usuario u in miCine.obtenerUsuarios())
            {

                dataGridView1.Rows.Add(new string[] { u.id.ToString(), u.dni, u.nombre, u.apellido, u.mail, u.contrasenia });

            }
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.transferencia();
        }

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

            textBox1.Text = id;
            textBox2.Text = dni;
            textBox3.Text = nombre;
            textBox4.Text = apellido;
            textBox5.Text = mail;
            textBox6.Text = contrasenia;
            selectedUser = int.Parse(id);
        }

        //AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox5.Text == null || textBox6.Text == null)
            {
                MessageBox.Show("Debe rellenar los datos para agregar al usuario");
            }
            else
                if (miCine.agregarUsuario(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text))
            {
                MessageBox.Show("Agregado con exito");
            } else
                MessageBox.Show("Problemas al agregar");
            
        }

        //MODIFICAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUser != -1)
            {
                if (miCine.modificarUsuario(selectedUser, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text))
                {
                    MessageBox.Show("Modificado con exito");
                }else
                    MessageBox.Show("No se pudo modificar");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un usuario");
            }
        }
        //ELIMINAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUser != -1)
            {
                if (miCine.eliminarUsuario(selectedUser))
                {
                    MessageBox.Show("Eliminado con exito");
                }
                else
                    MessageBox.Show("No se pudo eliminar");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un usuario");
            }
        }



        public delegate void Usuarios_Bienvenida();
    }
}
