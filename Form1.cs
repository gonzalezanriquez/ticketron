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
        private Cine cine;
        private Funcion funcion;
        private Usuario usuario;
        private Sala miSala;
        private Pelicula pelicula;
        
        private Registro hijoRegistro;
        private Login hijoLogin;

        private Inicio hijoInicio;
        private Administrador hijoAdministrador;
        private Usuarios hijoUsuarios;
        private Peliculas hijoPeliculas;
        private Salas hijoSalas;
        private Funciones hijoFunciones;

        private Cliente hijoCliente;
        private Compra hijoCompra;
        private ListCompras hijoListCompras;

      
        
        public Form1()
        {   
            cine = new Cine();
            InitializeComponent();

            #region DATOS DE PRUEBA
            
            /*DATOS DE PRUBA*/
            cine.agregarUsuario("32793188", "Leandro", "Gonzalez", "mail", "1234",true);
            cine.agregarUsuario("32793189", "Camila", "Giudice", "mail2", "3456",false);
            cine.agregarUsuario("32793180", "Kevin", "Hercog", "mail3", "7890",  false);

            cine.agregarPelicula( "El mago con patas", "Una pelicula muy buena recomendada para entendidos", "Poster1", 200);
            cine.agregarPelicula( "El perro sin patas", "Una pelicula muy mala no vengan a verla", "Poster2", 150);
            cine.agregarPelicula( "El baul acolchonado", "Una pelicula de calidad intermedia para los fanaticos de los baules", "Poster1", 170);

            cine.agregarSala("CaballitoA", 30);
            cine.agregarSala("CaballitoB", 40);
            cine.agregarSala("CaballitoC", 50);
            cine.agregarSala("CaballitoD", 60);
            cine.agregarSala("CaballitoE", 70);

            #endregion

            Open_Login(); 
            
            

        }
        #region RUTAS
        private void loginToInicio()
        {
            MessageBox.Show("Te damos la bienvenida,  " + cine.nombreLogueado(), "Inicio de Sesion - Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            hijoLogin.Close();
            Open_Inicio();
        }

        private void loginToRegistro()
        {
            hijoLogin.Close();
            Open_Registro();
        }

        private void inicioToAdmin()
        {
            hijoInicio.Close();
            Open_Admin();           
        }
        private void inicioToCliente()
        {
            hijoInicio.Close();
            Open_Cliente();
        }


  





      

        private void cierreSesion()
        {
            cine.cerrarSesion();
            Open_Login();
        }
        #endregion




        #region MDI CHILDREN
        private void Open_Registro()
        {
            hijoRegistro = new Registro(cine);
            hijoRegistro.MdiParent = this;
            hijoRegistro.Dock = DockStyle.Fill;
            hijoRegistro.t1 += toLogin;
            hijoRegistro.Show();
        }
        private void Open_Login()
        {
            hijoLogin = new Login(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill;
            hijoInicio.t1 += inicioToAdmin;
            hijoInicio.t2 += inicioAcliente;
            hijoInicio.t3 += cierreSesion;
            hijoLogin.Show();
        }

        private void Open_Inicio()
        {
            hijoInicio = new Inicio(cine);
            hijoInicio.MdiParent = this;
            hijoInicio.Dock = DockStyle.Fill;
            hijoInicio.Show();
            hijoInicio.t1 += cierreSesion;
        }
        private void Open_Admin()
        {
            hijoAdministrador = new Administrador(cine);
            hijoAdministrador.MdiParent = this;
            hijoAdministrador.Dock = DockStyle.Fill;
            hijoAdministrador.t1 += adminToUsuarios;
            hijoAdministrador.t2 += adminToPeliculas;
            hijoAdministrador.t3 += adminToSalas;
            hijoAdministrador.t4 += adminToFunciones;
            hijoAdministrador.t5 += cierreSesion;
            hijoAdministrador.Show();
        }

        private void Open_Usuarios()
        {
            hijoUsuarios = new Usuarios(cine);
            hijoUsuarios.MdiParent = this;
            hijoUsuarios.Dock = DockStyle.Fill;
            hijoUsuarios.Show();
        }
        private void Open_Peliculas()
        {
            hijoPeliculas = new Peliculas(cine);
            hijoPeliculas.MdiParent = this;
            hijoPeliculas.Dock = DockStyle.Fill;
            hijoPeliculas.Show();
        }       
        private void Open_Salas()
        {
            hijoSalas = new Salas(cine);
            hijoSalas.MdiParent = this;
            hijoSalas.Dock = DockStyle.Fill;
            hijoSalas.Show();
        }
        private void Open_Funciones()
        {
            hijoFunciones = new Funciones(cine);
            hijoFunciones.MdiParent = this;
            hijoFunciones.Dock = DockStyle.Fill;
            hijoFunciones.Show();
        }        
        
        private void Open_Cliente()
        {
            hijoCliente = new Cliente(cine);
            hijoCliente.MdiParent = this;
            hijoCliente.Dock = DockStyle.Fill;
            hijoCliente.t1 += ;
            hijoCliente.Show();
        }

        private void Open_ListCompras()
        {
            hijoListCompras = new ListCompras(cine);
            hijoListCompras.MdiParent = this;
            hijoListCompras.Dock = DockStyle.Fill;
            hijoListCompras.Show();
        }

        private void Open_Compra()
        {
            hijoCompra = new Compra(cine);
            hijoCompra.MdiParent = this;
            hijoCompra.Dock = DockStyle.Fill;
            hijoCompra.Show();
            hijoCompra t1 += compraToCliente;
        }

        #endregion

    }
}

