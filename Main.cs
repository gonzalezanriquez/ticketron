namespace TP1_GrupoB
{
    public partial class Main : Form
    {
        private Cine miCine;
        private int selectedUser;

        public Main(Cine cine)
        {
            InitializeComponent();
            miCine = cine;
            label1.Text = cine.nombreLogueado();


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

            dataGridView1.Rows.Add(new string[] { u.id.ToString(), u.dni.ToString(), u.nombre, u.apellido, u.mail, u.contrasenia });/*Siempre necesita un arreglo*/
            }
        }


    }
}
