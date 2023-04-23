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

        public Cine()
        {
            usuarios= new List<Usuario>();
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

        //Mostrar usuarios con lista Clon
        public List<Usuario> obtenerUsuarios() { 
            return usuarios.ToList();
        }
 

        // Cerrar Sesion
       

        /*
      
        



        public List<Funcion> Funciones = new List<Funcion> { Get; Set;};
        public List<Sala> Salas = new List<Sala> { Get; Set;};
        public List<Pelicula> peliculas = new List<Pelicula> { Get; Set;};
        public Usuario UsuarioActual { Get; Set; }

        
       
        public Cine(List<Usuario> Usuarios, List<Funcion> Funciones, List<Sala> Salas, List<Pelicula> Peliculas, Usuario UsuarioActual) {

        }      



       // ABM Entidades()
       
       // CargarCredito(int idUsuario, double importe){
        } 
        
       // ComprarEntrada(int idUsuario, int cant){
        }

       // DevolverEntrada(){
        }

    

       // MostrarFunciones(): List<Funcion>

       // MostrarSalas(): List<Sala>

       // MostrarPeliculas(): List<Post>   ¿?Así estaba en el diagrama

       // BuscarFuncion(string Ubicacion, Date Fecha, double Costo, string pelicula): List<Funcion>  
        
        
       */


    }

}
