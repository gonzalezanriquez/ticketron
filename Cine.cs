using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public List<Funcion> funciones { get; set; }
        public List<Sala> salas { get; set; }
        public List<Pelicula> peliculas { get; set; }
        public Usuario Logueado { get; set; }
        #endregion

        public Cine()
        {
            usuarios= new List<Usuario>();
            idUsuarios= 2;
            funciones= new List<Funcion>();
            salas= new List<Sala>();
            peliculas= new List<Pelicula>();

        }



        //Agregar usuarios
        public bool agregarUsuario(int dni, string nombre, string apellido, string mail, string contrasenia,bool isAdmin) {
            
            usuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, mail, contrasenia,isAdmin));
            idUsuarios++;
            return true;    
            
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

        public bool iniciarSesion(string mail, string contrasenia)
        {
            bool encontrado = false;
            foreach (Usuario usu in usuarios)
            {
                encontrado = false;


                if (!usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Usuario Incorrecto", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                } else if (!usu.contrasenia.Equals(contrasenia))
                {
                    if (usu.intentosFallidos > 3)
                    {
                        usu.isBloqueado = true;
                        MessageBox.Show("Tuviste 3 Intentos, tu usuario fue Bloqueado", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta.Intento N°: " + usu.intentosFallidos, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        usu.intentosFallidos++;
                        break;
                    }

                } else
                {
                    encontrado = true;
                    Logueado = usu;
                    break;
                }




                //if (usu.mail.Equals(mail, StringComparison.OrdinalIgnoreCase)&& usu.contrasenia.Equals(contrasenia)&& !usu.isBloqueado)
                //{
                //    encontrado = true;
                //    Logueado = usu;
                //    break;
                //}
                //else  
                //{
                //        if (usu.intentosFallidos>3)
                //        {

                //        usu.isBloqueado = true;
                //            MessageBox.Show("Tuviste 3 Intentos, tu usuario fue Bloqueado", "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //            break;
                //        }
                //        else
                //        {
                //        MessageBox.Show("Usuario y/o contraseña Incorrecta. Intento N°: "+ usu.intentosFallidos, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //        usu.intentosFallidos++;
                //        break;
                //    }
                //    }

                        
             
            }             

            return encontrado;
        }
    


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

        public void modificarUsuario(int id, string usuarios, string contrasenia)
        {

        }

        public string nombreLogueado()
        {
            return Logueado.nombre;
        }





        /*

       // Cerrar Sesion(){}

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
