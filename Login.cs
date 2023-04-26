namespace TP1_GrupoB
{
    public partial class Login : Form
    {
        private Cine miCine;
        public TrasnLogin transferencia;


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

            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario o una contraseña", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public delegate void TrasnLogin();




    }
}