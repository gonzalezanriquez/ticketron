namespace TP1_GrupoB
{
    public partial class Usuarios : Form
    {
        private Cine miCine;
        private int selectedUser;
        public UsuariosToAdmin t1;

        
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
        {  dataGridView1.Rows.Clear();

            foreach (Usuario u in miCine.obtenerUsuarios())
            {
                dataGridView1.Rows.Add(new string[] { u.id.ToString(), u.dni, u.nombre, u.apellido, u.mail, u.contrasenia, u.isAdmin.ToString() });
            }
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.t1();
        }

      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            boxId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            boxDni.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            boxNombre.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            boxApellido.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            boxMail.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            boxContrasenia.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            checkBoxIsAdmin.Checked = bool.Parse(dataGridView1[6, e.RowIndex].Value.ToString());


            selectedUser = int.Parse(boxId.Text);
        }

        //AGREGAR
        private void button1_Click(object sender, EventArgs e)

        {
            if (boxDni.Text == "" || boxNombre.Text == "" || boxApellido.Text == "" || boxContrasenia.Text == "" || boxMail.Text == "" || boxNombre.Text == null || boxApellido.Text == null || boxContrasenia.Text == null || boxMail.Text == null)
            {
                MessageBox.Show("Debe completar todos los campos","Ticketron", MessageBoxButtons.OK,MessageBoxIcon.Error);

                
            }
            else if (miCine.agregarUsuario(boxDni.Text, boxNombre.Text, boxApellido.Text, boxMail.Text, boxContrasenia.Text,0.00, checkBoxIsAdmin.Checked))
            {
                MessageBox.Show("Usuario agregado con Exito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Problemas al agregar", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //MODIFICAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUser != -1)
            {
                if (miCine.modificarUsuario(selectedUser, boxId.Text, boxNombre.Text, boxApellido.Text, boxContrasenia.Text, boxMail.Text,0.00, checkBoxIsAdmin.Checked))
                {
                    MessageBox.Show("Usuario Modificado con exito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("El usario no pudo ser modificado","Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un usuario", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }
        //ELIMINAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUser != -1)
            {
                if (miCine.eliminarUsuario(selectedUser))
                {
                    MessageBox.Show("Usuario Eliminado con exito", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("El usario no pudo ser eliminado", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un usuario", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }



        public delegate void UsuariosToAdmin();
    }
}
