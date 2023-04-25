using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    public class Cine
    {


        private List<Usuario> usuarios {  get; set; }
        private int idUsuarios{ get; set; }
        private List<Funcion> funciones { get; set; }
        private List<Sala> salas { get; set; }
        private List<Pelicula> peliculas { get; set; }
        private Usuario Logueado { get; set; }


        public Cine()
        {
            usuarios= new List<Usuario>();
            idUsuarios= 0;
            funciones= new List<Funcion>();
            salas= new List<Sala>();
            peliculas= new List<Pelicula>();
        }



        //Agregar usuarios
        public void agregarUsuario(int dni, string nombre, string apellido, string mail, string contrasenia) {

            usuarios.Add(new Usuario(idUsuarios,dni, nombre, apellido, mail, contrasenia));
            idUsuarios++;
           
            
        }
        /* Ejemplo de la clase version 2
        
        public void agregarUsuario(Usuario dni, Usuario nombre, Usuario apellido, Usuario mail, Usuario contrasenia) {
            Usuario otro = new Usuario(mail.dni, mail.nombre, mail.apellido, mail.mail, mail.contrasenia);
            usuarios.Add(otro);
            IdUsuarios++;
            otro.id = IdUsuarios;
        }
        */
  
        // Iniciar Sesion
        public bool iniciarSesion(string mail, string contrasenia) {
            bool encontrado = false;
            foreach (Usuario usu in usuarios) { 
                if(usu.mail.Equals(mail) && usu.contrasenia.Equals(contrasenia)){
                    encontrado = true;
                    Logueado= usu;
                    
                }
            }return encontrado;
        }

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

        public Boolean login(int dni, string pass)
        {
            foreach (Usuario usu in obtenerUsuarios())
            {
                if (usu.dni.Equals(dni) && usu.contrasenia.Equals(pass))
                {
                    return true;
                }
            }
            return false;
        }

        public string nombreLogueado()
        {
            return Logueado.nombre;
        }













        /*

       // Cerrar Sesion(){}

       // public Cine(List<Usuario> Usuarios, List<Funcion> Funciones, List<Sala> Salas, List<Pelicula> Peliculas, Usuario UsuarioActual) {}   



       // ABM Entidades()

       // CargarCredito(int idUsuario, double importe){
        } 

       // ComprarEntrada(int idUsuario, int cant){
        }

       // DevolverEntrada(){
        }


       // BuscarFuncion(string Ubicacion, Date Fecha, double Costo, string pelicula): List<Funcion>  


       */


    }

}
