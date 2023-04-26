﻿using System;
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
        public bool agregarUsuario(int dni, string nombre, string apellido, string mail, string contrasenia) {
            
            usuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, mail, contrasenia));
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
                
                if(usu.mail.Equals(mail) && usu.contrasenia.Equals(contrasenia))
                {
                    encontrado = true;
                    Logueado = usu;
                    break;
                }
                else
                {
                    MessageBox.Show("PUTO " , "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                }

                #region revisar

                //}
                //if (usu.isBloqueado)
                //{
                //    MessageBox.Show("EL USUARIO FUE BLOQUEADO. " + usu.isBloqueado + " " + usu.nombre, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //    break;
                //}
                //else if (usu.mail.Equals(mail))
                //{
                //    MessageBox.Show("Usuario Correcto - " + usu.mail + "- " + mail, "Ticketron", MessageBoxButtons.OK);
                //    break;
                //}
                //else if (!usu.mail.Equals(mail))
                //{
                //    MessageBox.Show("Usuario Incorrecto - " + usu.mail + "- " +mail , "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //}
                //else if (!usu.contrasenia.Equals(contrasenia))
                //{
                //    if (usu.intentosFallidos > 3)
                //    {
                //        usu.isBloqueado = true;
                //        MessageBox.Show("Tuviste 3 Intentos, tu usuario fue Bloqueado" + usu.nombre, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //        break;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Contraseña Incorrecta.Intento N°: " + usu.intentosFallidos, "Ticketron", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //        usu.intentosFallidos++;
                //        break;
                //    }
                //}
                //else
                //{
                //    encontrado = true;
                //    Logueado = usu;
                //    break;
                //}
                #endregion
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

        //Modificar Usuarios
        public bool modificarUsuario(int id, string mail, string contrasenia)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == id)
                {
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
