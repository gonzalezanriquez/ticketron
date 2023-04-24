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
    }
}
