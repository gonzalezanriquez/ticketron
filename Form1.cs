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
        private Peliculas hijoPeliculas;
        private Salas hijoSalas;
        private Funciones hijoFunciones;
        private Login hijoLogin;
        private Usuarios hijoUsuarios;
        private Bienvenida hijoBienvenida;
        private Inicio hijoInicio;


        public Form1()
        {   
            cine = new Cine();
            InitializeComponent();

            
            
            cine.agregarUsuario("32793188", "Leandro", "Gonzalez", "mail", "1234",true);
            cine.agregarUsuario("32793189", "Camila", "Giudice", "mail2", "3456",false);
            cine.agregarUsuario("32793180", "Kevin", "Hercog", "mail3", "7890", false);

            cine.agregarPelicula( "El mago con patas", "Una pelicula muy buena recomendada para entendidos", "Poster1", 200);
            cine.agregarPelicula( "El perro sin patas", "Una pelicula muy mala no vengan a verla", "Poster2", 150);
            cine.agregarPelicula( "El baul acolchonado", "Una pelicula de calidad intermedia para los fanaticos de los baules", "Poster1", 170);

            cine.agregarSala( "CaballitoA", 30);
            cine.agregarSala("CaballitoB", 40);
            cine.agregarSala("CaballitoC", 50);
            cine.agregarSala("CaballitoD", 60);
            cine.agregarSala("CaballitoE", 70);


            cine.agregarFuncion( 300, 50, DateTime.Today, pelicula, miSala);
            cine.agregarFuncion(400, 70, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(500, 90, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(300, 50, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(400, 70, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(500, 90, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(300, 50, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(400, 70, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(500, 90, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(300, 50, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(400, 70, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(500, 90, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(300, 50, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(400, 70, DateTime.Now, pelicula, miSala);
            cine.agregarFuncion(500, 90, DateTime.Now, pelicula, miSala);
                

          


            Open_Login();


        }

        private void TLogin()
        {           
            MessageBox.Show("Te damos la bienvenida,  " + cine.nombreLogueado(), "Inicio de Sesion - Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            hijoLogin.Close();

            Open_Inicio();

            hijoInicio.transf1 += Inicio_a_Bienvenida;






        }
  
        private void Inicio_a_Bienvenida()
        {
            hijoInicio.Close();
            Open_Bienvenida();

            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.transferencia2 += Bienvenida_a_Funciones;
            hijoBienvenida.transferencia3 += Bienvenida_a_Peliculas;
            hijoBienvenida.transferencia4 += Bienvenida_a_Salas;
            hijoBienvenida.Show();
        }


        #region Peliculas
        private void Bienvenida_a_Peliculas()
        {
            hijoBienvenida.Close();
            Open_Peliculas();
            hijoPeliculas.transferencia3 += Peliculas_Bienvenida;
            hijoPeliculas.Show();

        }


        private void Peliculas_Bienvenida()
        {
            hijoPeliculas.Close();
            Open_Bienvenida();
            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.transferencia2 += Bienvenida_a_Funciones;
            hijoBienvenida.transferencia3 += Bienvenida_a_Peliculas;
            hijoBienvenida.transferencia4 += Bienvenida_a_Salas;
            hijoBienvenida.Show();



        }

        #endregion

        #region Funciones
        private void Bienvenida_a_Funciones()
        {
            hijoBienvenida.Close();
            Open_Funciones();
            hijoFunciones.transferencia2 += Funciones_Bienvenida;
            hijoFunciones.Show();

        }

        private void Funciones_Bienvenida()
        {
            hijoFunciones.Close();
            Open_Bienvenida();
            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.transferencia2 += Bienvenida_a_Funciones;
            hijoBienvenida.transferencia3 += Bienvenida_a_Peliculas;
            hijoBienvenida.transferencia4 += Bienvenida_a_Salas;
            hijoBienvenida.Show();

        }
        #endregion

        #region Salas

        private void Bienvenida_a_Salas()
        {
            hijoBienvenida.Close();
            Open_Salas();
            hijoSalas.transferencia4 += Salas_Bienvenida;
            hijoSalas.Show();

        }


        private void Salas_Bienvenida()
        {
            hijoSalas.Close();
            Open_Bienvenida();
            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.transferencia2 += Bienvenida_a_Funciones;
            hijoBienvenida.transferencia3 += Bienvenida_a_Peliculas;
            hijoBienvenida.transferencia4 += Bienvenida_a_Salas;
            hijoBienvenida.Show();



        }

        #endregion 

        #region Usuarios
        private void Bienvenida_a_Usuarios()
        {
            hijoBienvenida.Close();
            Open_Usuarios();           
            hijoUsuarios.transferencia += Usuarios_Bienvenida;
            hijoUsuarios.Show();

        }


        private void Usuarios_Bienvenida()
        {
            hijoUsuarios.Close();
            Open_Bienvenida();
            hijoBienvenida.transferencia += Bienvenida_a_Usuarios;
            hijoBienvenida.transferencia2 += Bienvenida_a_Funciones;
            hijoBienvenida.transferencia3 += Bienvenida_a_Peliculas;
            hijoBienvenida.transferencia4 += Bienvenida_a_Salas;
            hijoBienvenida.Show();



        }


     

        #endregion

        /*----------------------------------------------------------------*/
        
        private void Open_Inicio()
        {
            hijoInicio = new Inicio(cine);
            hijoInicio.MdiParent= this;
            hijoInicio.Dock = DockStyle.Fill;
            hijoInicio.Show();
        }
        
        
        private void Open_Bienvenida()
        {
            hijoBienvenida = new Bienvenida(cine);
            hijoBienvenida.MdiParent = this;
            hijoBienvenida.Dock = DockStyle.Fill; 
            hijoBienvenida.Show();
        }

        //prueba
        private void Open_Funciones()
        {
            hijoFunciones = new Funciones(cine);
            hijoFunciones.MdiParent = this;
            hijoFunciones.Dock = DockStyle.Fill;
            
        }

        private void Open_Usuarios()
        {
            hijoUsuarios = new Usuarios(cine);
            hijoUsuarios.MdiParent = this;
            hijoUsuarios.Dock = DockStyle.Fill;
      
        }

        private void Open_Peliculas()
        {
            hijoPeliculas = new Peliculas(cine);
            hijoPeliculas.MdiParent = this;
            hijoPeliculas.Dock = DockStyle.Fill;

        }

        private void Open_Salas()
        {
            hijoSalas = new Salas(cine);
            hijoSalas.MdiParent = this;
            hijoSalas.Dock = DockStyle.Fill;

        }
        private void Open_Login()
        {
            hijoLogin = new Login(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill; /*Para adaptar el contenido dentro de el contenedor */
            hijoLogin.transferencia += TLogin;

            hijoLogin.Show();
        }



        private void Form1_Load(object sender, EventArgs e) {  }
    }
}
