using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GrupoB
{
    internal class Cine
    {


        private List<Usuario> usuarios;
        private List<Funcion> funciones;
        private List<Sala> salas;
        private List<Pelicula> peliculas;
        //public Usuario UsuarioActual { Get; Set; }


        public Cine()
        {
            usuarios= new List<Usuario>();
            funciones= new List<Funcion>();
            salas= new List<Sala>();
            peliculas= new List<Pelicula>();
        }

        //Agregar usuarios
        public void agregarUsuario(int dni, string nombre, string apellido, string mail, string contrasenia) {

            usuarios.Add(new Usuario(dni, nombre, apellido, mail, contrasenia));
        
        }

  
        // Iniciar Sesion
        public bool iniciarSesion(string mail, string contrasenia) {
            bool encontrado = false;
            foreach (Usuario Mail in usuarios) { 
                if(Mail.mail.Equals(mail) && Mail.contrasenia.Equals(contrasenia)){
                    encontrado = true;
                    
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
