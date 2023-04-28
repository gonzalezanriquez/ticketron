using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    public class Cine
    {
        #region atributos
        public List<Usuario> usuarios {  get; set; }
        public int idUsuarios{ get; set; }

        public int idFunciones { get; set; }

        public int idPeliculas{ get; set; }

        public int idSalas { get; set; }
        public List<Funcion> funciones { get; set; }
        public List<Sala> salas { get; set; }
        public List<Pelicula> peliculas { get; set; }
        public Usuario Logueado { get; set; }
        #endregion

        public Cine()
        {
            usuarios= new List<Usuario>();
            idUsuarios= 0;
            idFunciones = 0;
            idPeliculas = 0;
            idSalas = 0;
            funciones = new List<Funcion>();
            salas= new List<Sala>();
            peliculas= new List<Pelicula>();
        }
        //Agregar usuarios
        public bool agregarUsuario(string dni, string nombre, string apellido, string mail, string contrasenia) {
            
            usuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, mail, contrasenia));
            idUsuarios++;
            return true;    
            
        }

        public bool agregarFuncion(int cantClientes, double costo, DateTime fecha, Pelicula pelicula,Sala miSala)
        {

            funciones.Add(new Funcion(idFunciones, cantClientes, costo ,fecha, pelicula, miSala));
            idFunciones++;
            return true;

        }

        public bool agregarPelicula(string nombre, string sinopsis, string poster, int duracion)
        {

            peliculas.Add(new Pelicula(idPeliculas, nombre, sinopsis , poster , duracion));
            idPeliculas++;
            return true;

        }

        public bool agregarSala(string ubicacion, int capacidad)
        {

            salas.Add(new Sala(idSalas,ubicacion,capacidad));
            idSalas++;
            return true;

        }

        #region revisar
        /* Ejemplo de la clase version 2
        
        public void agregarUsuario(Usuario dni, Usuario nombre, Usuario apellido, Usuario mail, Usuario contrasenia) {
            Usuario otro = new Usuario(mail.dni, mail.nombre, mail.apellido, mail.mail, mail.contrasenia);
            usuarios.Add(otro);
            IdUsuarios++;
            otro.id = IdUsuarios;
        }
        */
        #endregion

        // Iniciar Sesion

        #region inicioSesion
        public bool iniciarSesion(string mail, string contrasenia)
        {
            bool encontrado = false;
            foreach (Usuario usu in usuarios)
            {

                if (!usu.mail.Equals(mail))
                {
                    continue;
                }

                if (usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase) && usu.contrasenia.Equals(contrasenia) && usu.intentosFallidos < 4)
                {
                    Logueado = usu;
                    return true;



                }

                if (usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase) && !usu.contrasenia.Equals(contrasenia) && usu.intentosFallidos < 3)
                {
                    MessageBox.Show("Contraseña Incorrecta.Intento N°: " + usu.intentosFallidos, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usu.intentosFallidos++;

                    return false;
                }

                if (usu.isBloqueado == true || usu.intentosFallidos >= 3)
                {
                    MessageBox.Show("Usuario bloqueado, pruebe con otro", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            MessageBox.Show("Usuario no encontrado ", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return encontrado;
        }

# endregion


        #region Métodos
        //Mostrar Usuarios, Funciones, Salas y Peliculas con lista clon
        public List<Usuario> obtenerUsuarios() { 
            return usuarios.ToList();
        }
        public List<Funcion> obtenerFuncion() { 
            return funciones.ToList();
        }
        public List<Sala> obtenerSalas() { 
            return salas.ToList();
        }
        public List<Pelicula> obtenerPeliculas() { 
        return peliculas.ToList();
        }
        #endregion

        //Modificar Usuarios
        public bool modificarUsuario(int id,string dni, string nombre, string apellido, string mail, string contrasenia)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
                    usu.nombre = nombre;
                    usu.apellido = apellido;
                    usu.dni = dni;
                    usu.mail = mail;
                    usu.contrasenia = contrasenia;
                    return true;
                }
            }
            return false;
        }


        //Eliminar usuarios
        public bool eliminarUsuario(int id)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
                    usuarios.Remove(usu);
                    return true;
                }
            }
            return false;
        }

        //Logueado ahora
        public string nombreLogueado()
        {
            return Logueado.nombre;
        }

        public bool comprarEntrada(Usuario Logueado, decimal cantidad)
        {
            foreach (Funcion f in funciones) {

                Boolean compra = false;

                if (cantidad + f.cantClientes < f.miSala.capacidad)
                {
                    MessageBox.Show("Compra exitosa");
                }
                    MessageBox.Show("Disculpe la sala esta llena");

                if (Logueado.credito > f.costo) {

                    MessageBox.Show("Tiene saldo disponible para realizar la compra");
                    compra = true;
                }
                    MessageBox.Show("No tiene saldo suficiente para realiza la compra");
                    compra = false;

                if (!compra)
                {
                    MessageBox.Show("No se realizo la compra");
                    break;

                }
                MessageBox.Show("La compra fue exitosa");
                MessageBox.Show("SE COMPRARON: " + cantidad + "ENTRADAS");
                Logueado.credito = Logueado.credito - f.costo;
                f.clientes.Add(Logueado);
                //Logueado.misFunciones.Add(id);
                f.cantClientes = f.cantClientes + (int)cantidad;

                    
                
            
            
            
            
            
            }
            return true;
        }

        /*

       // Cerrar Sesion(){}

       // ABM Entidades()

       // CargarCredito(int idUsuario, double importe){
        } 

        ComprarEntrada(int idUsuario, int cant){
        }

       // DevolverEntrada(){
        }


       // BuscarFuncion(string Ubicacion, Date Fecha, double Costo, string pelicula): List<Funcion>  


       */


    }

}
