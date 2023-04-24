using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GrupoB
{
    public partial class Form1 : Form
    {

        Login hijoLogin;
        public Form1()
        {
            InitializeComponent();
            Cine cine = new Cine();
            hijoLogin = new Login();
            hijoLogin.MdiParent = this;
            hijoLogin.TopLevel = false;
            hijoLogin.Dock = DockStyle.Fill;
            hijoLogin.Show();
             





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
