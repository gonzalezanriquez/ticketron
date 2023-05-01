namespace TP1_GrupoB
{
    public partial class Login : Form
    {
        private Cine miCine;
        public loginToInicio t1;
        public loginToRegistro t2;





        public Login(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string mail = labelUsuario.Text;
            string pass = labelContrasenia.Text;

            if (mail != null && mail != "" && pass != null && pass != "")
            {

                switch (miCine.iniciarSesion(mail, pass))
                {
                    case var tuple when tuple.Item1 == 1:

                        this.t1();

                        break;
                    case var tuple when tuple.Item1 == 2:
                        MessageBox.Show("Contraseña Incorrecta. Intento N°: " + tuple.Item2, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        break;
                    case var tuple when tuple.Item1 == 3:
                        MessageBox.Show("Usuario bloqueado, pruebe con otro", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        break;
                    case var tuple when tuple.Item1 == 4:

                        MessageBox.Show("Usuario no encontrado. Ingrese un usuario valido ", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        break;

                }





            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario o una contraseña", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.t2();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.t2();
        }

        public delegate void loginToInicio();
        public delegate void loginToRegistro();




    }
}