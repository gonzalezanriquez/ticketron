namespace TP1_GrupoB
{
    public partial class Usuarios : Form
    {
        private Cine miCine;
        public Usuarios_Bienvendia transferencia;

        public Usuarios(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            label1.Text = miCine.nombreLogueado();
        }



        private void botonMostrarUsuarios_Click(object sender, EventArgs e)
        {

            refreshData();
        }

        private void refreshData()
        {

            dataGridView1.Rows.Clear();

            foreach (Usuario u in miCine.obtenerUsuarios())
            {

                dataGridView1.Rows.Add(new string[] { u.id.ToString(), u.dni.ToString(), u.apellido, u.apellido, u.mail, u.contrasenia, u.isAdmin.ToString() });

            }
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.transferencia();
        }

        public delegate void Usuarios_Bienvendia();
    }
}
