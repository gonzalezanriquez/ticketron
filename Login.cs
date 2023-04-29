namespace TP1_GrupoB
{
    public partial class Login : Form
    {
        private Cine miCine;
        public TLogin transferencia;
        public TLogin transferencia2;
        public TLogin transferencia3;
        public TLogin transferencia4;
        public Open_Registro verRegistro;


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

                        this.transferencia();

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

        private void button2_Click(object sender, EventArgs e)
        {

            this.verRegistro();
        
        }

        public delegate void TLogin();
        public delegate void Open_Registro();




    }
}