namespace TP1_GrupoB
{
    public partial class Login : Form
    {
        private Cine miCine;
        public TransfDelegado transferencia;

        public Login(Cine cin)
        {
            miCine = cin;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mail = labelUsuario.Text;
            string pass = labelContrasenia.Text;

            if (mail != null && mail != "" && pass != null && pass != "")
            {
                if (miCine.iniciarSesion(mail, pass))
                {
                    this.transferencia();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario o una contraseña");


            }
        }

        //Cine cine1 = new Cine();

        //cine1.agregarUsuario(32793188, "Leandro", "Gonzalez", "mail", "1234");

        //int dni = Int32.Parse(labelUsuario.Text);/*CASTEAR PARA EL INGRESO DE TEXTO  A INT*/

        //if (cine1.login(dni, labelContrasenia.Text))
        //{
        //    MessageBox.Show("ENCONTRADO", "Podes Ingresar");
        //}
        //else
        //{
        //    MessageBox.Show("NO ENCONTRADO", "Acceso Incorrecto");

        //}



        public delegate void TransfDelegado();



    }
}