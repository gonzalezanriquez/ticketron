namespace TP1_GrupoB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cine cine1 = new Cine();
            cine1.agregarUsuario(32793188, "Leandro", "Gonzalez", "mail", "1234");

            int dni = Int32.Parse(labelUsuario.Text);/*CASTEAR PARA EL INGRESO DE TEXTO  A INT*/

            if (cine1.login(dni, labelContrasenia.Text))
            {
                MessageBox.Show("ENCONTRADO", "Podes Ingresar");
            }
            else
            {
                MessageBox.Show("NO ENCONTRADO", "Acceso Incorrecto");

            }





        }
    }
}