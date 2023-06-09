﻿using System;
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

        private Perfil hijoPerfil;

      
        
        public Form1()
        {
            
            cine = new Cine();
            
            InitializeComponent();

            #region DATOS DE PRUEBA
            
            /*DATOS DE PRUBA*/
            cine.agregarUsuario("32793188", "Leandro", "Gonzalez", "mail", "1234",1000.00,true);
            cine.agregarUsuario("32793189", "Camila", "Giudice", "mail2", "3456", 1000.00, false);
            cine.agregarUsuario("32793180", "Kevin", "Hercog", "mail3", "7890", 1000.00, false);

            cine.agregarPelicula( "El mago con patas", "Una pelicula muy buena recomendada para entendidos", "Poster1", 200);
            cine.agregarPelicula( "El perro sin patas", "Una pelicula muy mala no vengan a verla", "Poster2", 150);
            cine.agregarPelicula( "El baul acolchonado", "Una pelicula de calidad intermedia para los fanaticos de los baules", "Poster1", 170);

            cine.agregarSala("CaballitoA", 30);
            cine.agregarSala("CaballitoB", 40);
            cine.agregarSala("CaballitoC", 50);
            cine.agregarSala("CaballitoD", 60);
            cine.agregarSala("CaballitoE", 70);

            DateTime fecha = new DateTime(2023, 5, 1, 5, 12, 55);

            cine.agregarFuncion("CaballitoA", "El mago con patas",  fecha, 300);
            cine.agregarFuncion("CaballitoB", "El mago con patas",  fecha, 423);
            cine.agregarFuncion("CaballitoC", "El perro sin patas",  fecha, 223);
            cine.agregarFuncion("CaballitoD", "El perro sin patas",  fecha, 123);
            cine.agregarFuncion("CaballitoE", "El baul acolchonado",  fecha, 333);
           






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

        private void registroTologin()
        {
            hijoRegistro.Close();
            Open_Login();
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

        private void AdminToUsuarios()
        {
            hijoAdministrador.Close();
            Open_Usuarios();
        }
        private void AdminToPeliculas()
        {
            hijoAdministrador.Close();
            Open_Peliculas();
        }
        private void AdminToSalas()
        {
            hijoAdministrador.Close();
            Open_Salas();
        }
        private void AdminToFunciones()
        {
            hijoAdministrador.Close();
            Open_Funciones();
        }
        private void AdminToInicio()
        {
            hijoAdministrador.Close();
            Open_Inicio ();
        }
        private void UsuariosToAdmin()
        {
            hijoUsuarios.Close();
            Open_Admin();
        }
        private void PeliculasToAdmin()
        {
            hijoPeliculas.Close();
            Open_Admin();
        }
        private void SalasToAdmin()
        {
            hijoSalas.Close();
            Open_Admin();
        }
        private void FuncionesToAdmin()
        {
            hijoFunciones.Close();
            Open_Admin();
        }

        private void ClienteToCompra()
        {
            hijoCliente.Close();
            Open_Compra();
        }

        private void ClienteToInicio()
        {
            hijoCliente.Close();
            Open_Inicio();
        }

        private void CompraToCliente()
        {
            hijoCompra.Close();
            Open_Cliente();
        }

        private void ClienteToListCompras()
        {
            hijoCliente.Close();
            Open_ListCompras();

        }

        private void ListComprasToCliente()
        {
            hijoListCompras.Close();
            Open_Cliente();
        }


        private void cierreSesion()
        {
            cine.cerrarSesion();
            Open_Login();
        }

        private void ClienteToPerfil()
        {
            hijoCliente.Close();
            Open_Perfil();

        }

        private void PerfiltoCliente()
        {
            hijoPerfil.Close();
            Open_Cliente();

        }


        #endregion





        #region MDI CHILDREN
        private void Open_Registro()
        {
            hijoRegistro = new Registro(cine);
            hijoRegistro.MdiParent = this;
            hijoRegistro.Dock = DockStyle.Fill;
            hijoRegistro.t1 += registroTologin;
            hijoRegistro.Show();
        }
        private void Open_Login()
        {
            hijoLogin = new Login(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill;
            hijoLogin.t1 += loginToInicio;
            hijoLogin.t2 += loginToRegistro;            
            hijoLogin.Show();
        }
        private void Open_Inicio()
        {
            hijoInicio = new Inicio(cine);
            hijoInicio.MdiParent = this;
            hijoInicio.Dock = DockStyle.Fill;
            hijoInicio.t1 += inicioToAdmin;
            hijoInicio.t2 += inicioToCliente;
            hijoInicio.t3 += cierreSesion;
            hijoInicio.Show();
        }
        private void Open_Admin()
        {
            hijoAdministrador = new Administrador(cine);
            hijoAdministrador.MdiParent = this;
            hijoAdministrador.Dock = DockStyle.Fill;
            hijoAdministrador.t1 += AdminToUsuarios;
            hijoAdministrador.t2 += AdminToPeliculas;
            hijoAdministrador.t3 += AdminToSalas;
            hijoAdministrador.t4 += AdminToFunciones;
            hijoAdministrador.t5 += AdminToInicio;
            hijoAdministrador.t6 += cierreSesion;
            hijoAdministrador.Show();
        }
        private void Open_Usuarios()
        {
            hijoUsuarios = new Usuarios(cine);
            hijoUsuarios.MdiParent = this;
            hijoUsuarios.Dock = DockStyle.Fill;
            hijoUsuarios.t1 = UsuariosToAdmin;
            hijoUsuarios.Show();
        }
        private void Open_Peliculas()
        {
            hijoPeliculas = new Peliculas(cine);
            hijoPeliculas.MdiParent = this;
            hijoPeliculas.Dock = DockStyle.Fill;
            hijoPeliculas.t1 = PeliculasToAdmin;
            hijoPeliculas.Show();
        }       
        private void Open_Salas()
        {
            hijoSalas = new Salas(cine);
            hijoSalas.MdiParent = this;
            hijoSalas.Dock = DockStyle.Fill;
            hijoSalas.t1 = SalasToAdmin;
            hijoSalas.Show();
        }
        private void Open_Funciones()
        {
            hijoFunciones = new Funciones(cine);
            hijoFunciones.MdiParent = this;
            hijoFunciones.Dock = DockStyle.Fill;
            hijoFunciones.t1= FuncionesToAdmin;
            hijoFunciones.Show();
        }                
        private void Open_Cliente()
        {
            hijoCliente = new Cliente(cine);
            hijoCliente.MdiParent = this;
            hijoCliente.Dock = DockStyle.Fill;
            hijoCliente.t1 += ClienteToCompra;
            hijoCliente.t2 += ClienteToListCompras;
            hijoCliente.t3 += ClienteToInicio;
            hijoCliente.t4 += ClienteToPerfil;
            hijoCliente.Show();
        }

        private void Open_Compra()
        {
            hijoCompra = new Compra(cine);
            hijoCompra.MdiParent = this;
            hijoCompra.Dock = DockStyle.Fill;
            hijoCompra.t1 += CompraToCliente;
            hijoCompra.Show();
        }
        private void Open_ListCompras()
        {
            hijoListCompras = new ListCompras(cine);
            hijoListCompras.MdiParent = this;
            hijoListCompras.Dock = DockStyle.Fill;
            hijoListCompras.t1 += ListComprasToCliente;
           
            hijoListCompras.Show();
        }

        private void Open_Perfil()
        {
            hijoPerfil = new Perfil(cine);
            hijoPerfil.MdiParent = this;
            hijoPerfil.Dock = DockStyle.Fill;
            hijoPerfil.t1 = PerfiltoCliente;
            hijoPerfil.Show();
        }

        #endregion

    }
}

