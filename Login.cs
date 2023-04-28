namespace TP1_GrupoB
{
    public partial class Login : Form
    {
        private Cine miCine;
        public TLogin transferencia;
        public TLogin transferencia2;
        public TLogin transferencia3;
        public TLogin transferencia4;


        public Login(Cine cine)
        {
            miCine = cine;
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
                MessageBox.Show("Debe ingresar un usuario o una contraseņa", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public delegate void TLogin();




    }
}