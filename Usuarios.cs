namespace TP1_GrupoB
{
    public partial class Usuarios : Form
    {
        private Cine miCine;
        private int selectedUser;
        public TrasnfUsuarios transferencia;

        public Usuarios(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            label1.Text = cine.nombreLogueado();
        }



        private void botonMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.transferencia();
            refreshData();
        }

        private void refreshData()
        {

            dataGridView1.Rows.Clear();

            foreach (Usuario u in miCine.obtenerUsuarios())
            {

                dataGridView1.Rows.Add(new string[] { u.id.ToString(), u.dni.ToString(), u.nombre, u.apellido, u.mail, u.contrasenia, u.isAdmin.ToString() });

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.transferencia();
        }

        public delegate void TrasnfUsuarios();
    }
}
